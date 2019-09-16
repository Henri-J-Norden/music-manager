using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;
using System.Linq;

namespace MusicManager {
    public class TagManager {        
        public string directory = Directory.GetCurrentDirectory();
        
        public List<string> parsedPattern;
        private string _pattern;
        public string pattern {
            set {
                _pattern = value;
                ParsePattern();
            }
            get { return _pattern; }
        }

        //--- these settings MUST be identical to the values set in the form ---
        public int maxDepth = -1;
        public string artistSeparator = ", ";
        public char folderSeparator = '\\';
        public bool overwrite = false;
        public bool moveFilesToDirectory = true;
        public bool unicodeReplace = true;
        //---

        public Dictionary<string, string> filenameReplacements = new Dictionary<string, string>() { //(mostly) unicode fullwidth replacements for forbidden characters
            {"\"", "''" },//"＂"},
            {":",  ";" },//"："},
            {">", "＞"},
            {"<","＜" },
            {"/", "／"},
            {"\\", "＼"},
            {"|", "｜"}, 
            {"?","？"},
            {"*", "∗"}
        };

        public HashSet<string> supportedFormats = new HashSet<string> {
            ".mp3", ".flac", ".mp4", ".m4a", ".m4p", ".m4b", ".m4r", ".m4v", ".ogg", ".ogv", ".oga", ".ogx", ".ogm", ".spx", ".opus", ".aiff", ".aif", ".aifc", ".wav", ".wave", ".wv", ".asf", ".wma", ".wmv", ".mpc", ".mp+", ".mpp"
        };
                
        /// <summary>
        /// ONLOAD
        /// </summary>
        public TagManager() {
            
        }

        /// <summary>
        /// If <unicodeReplace> option is true, replaces illegal characters with unicode ones; any remaining illegal characters are removed
        /// </summary>
        public string SafeFilename(string dangerousName, bool ignoreDirs = false) {
            if (dangerousName == null) {
                return "";
            }
            string p = dangerousName;
            if (unicodeReplace) {
                foreach (string key in filenameReplacements.Keys) {
                    if (ignoreDirs && (key == "/" || key == "\\")) {
                        continue;
                    }
                    p = p.Replace(key, filenameReplacements[key]);
                }
            }
            foreach (char invalid in Path.GetInvalidFileNameChars()) {
                if (ignoreDirs && (invalid == '\\' || invalid == '/')) {
                    continue;
                }
                p = p.Replace(invalid.ToString(), "");
            }
            return p.TrimEnd();
        }

        private void ParsePattern() {
            List<string> parsed = new List<string> { };
            string temp = "";
            foreach (char ch in pattern) {
                if (ch == '<') {
                    parsed.Add(temp);
                    temp = "";
                } else if (ch == '>') {
                    parsed.Add(temp.ToLower());
                    temp = "";
                } else {
                    temp = temp + ch;
                }
            }
            parsed.Add(temp);
            parsedPattern = parsed;
        }

        /// <summary>
        /// Recursively checks all subdirectories of <dir> until maxDepth is reached and returs the absolute paths of all found directories
        /// </summary>
        private List<string> GetSubDirs(string dir, List<string> dirList = null, int curLevel = 0) {
            if (dirList == null) {
                dirList = new List<string>();
            }
            if (maxDepth == -1 || curLevel < maxDepth) {
                foreach (string d in Directory.GetDirectories(dir)) {
                    dirList.Add(d);
                    dirList = GetSubDirs(d, dirList, curLevel + 1);
                }
            }
            return dirList;
        }

        /// <summary>
        /// Returns the filename of the file at <filePath> based on the current pattern
        /// </summary>
        private string GetMP3FileName(string filePath) {
            TagLib.File file;
            try {
                file = TagLib.File.Create(filePath);
            } catch (TagLib.CorruptFileException) {
                return ".";
            }
            string pathName;
            if (!moveFilesToDirectory) {
                string[] path = filePath.Split("\\/".ToCharArray());
                path[path.Length - 1] = "";
                pathName = string.Join(folderSeparator.ToString(), path);
            } else {
                pathName = directory;
            }

            string fileName = "";
            int index = 0;
            foreach (string part in parsedPattern) {
                if (index % 2 == 1) { //is a user specified variable
                    switch (part) {
                        case "title":
                            fileName += SafeFilename(file.Tag.Title);
                            break;
                        case "firstartist":
                            fileName += SafeFilename(file.Tag.FirstAlbumArtist);
                            break;
                        case "firstperformer":
                            fileName += SafeFilename(file.Tag.FirstPerformer);
                            break;
                        case "album":
                            fileName += SafeFilename(file.Tag.Album);
                            break;
                        case "track":
                            fileName += SafeFilename(file.Tag.Track.ToString());
                            break;
                        case "artists":
                            fileName += SafeFilename(string.Join(artistSeparator, file.Tag.AlbumArtists));
                            break;
                        case "performers":
                            fileName += SafeFilename(string.Join(artistSeparator, file.Tag.Performers));
                            break;
                        case "year":
                            fileName += SafeFilename(file.Tag.Year.ToString());
                            break;
                    }
                    
                    
                } else { //is a user specified constant value (or empty)
                    fileName += part;
                }
                index++;
            }

            return pathName + SafeFilename(fileName, true) + "." + filePath.Split('.').Last();
        }

        public void SetMP3Names() {
            SetMP3Names(new ProgressBar());
        }

        /// <summary>
        /// Sets the name of ANY SUPPORTED FILE to their tags, based on on the given pattern
        /// Return codes:
        /// 0 = Renaming completed without errors
        /// 1 = Errors were encountered, but were solved
        /// 2 = Errors were encountered and ignored
        /// 10 = User aborted after error
        /// </summary>
        public int SetMP3Names(ProgressBar bar) {
            Console.WriteLine("Renaming files in directory " + directory);
            List<string> dirs = GetSubDirs(directory); //gets the absolute paths of all affected subdirectories
            dirs.Add(directory); //adds the current directory to the list
            bar.Maximum = dirs.Count; 
            bar.Value = 0;
            int statusCode = 0;
            foreach (string d in dirs) {
                foreach (string f in Directory.EnumerateFiles(d)) { //each file in each applicable directory is checked
                    foreach (string format in supportedFormats) {
                        if (f.EndsWith(format, true, System.Globalization.CultureInfo.CurrentCulture)) { //if a supported file is found
                            string newName = GetMP3FileName(f);
                            if (newName == f || (newName.Split('.').Length == 2 && newName.Split('.')[0].Length == 0)) { //file is ignored if it already has the correct name
                                continue;
                            }
                            Directory.CreateDirectory(Path.GetDirectoryName(newName));
                            if (File.Exists(newName)) {
                                if (overwrite) {
                                    File.Delete(newName);
                                } //not sure if it's better to show an error if the file already exists and user has chosen to no overwrite or just silently fail and pass over the file
                            }
                            string status = "Run";
                            while (status == "Retry" || status == "Run") {
                                try {
                                    File.Move(f, newName);
                                } catch (System.Exception ex) {
                                    status = MessageBox.Show("Source file:\n" + f + "\n\nDestination file:\n" + newName + "\n\nError:\n" + ex.Message, "Moving a file failed!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2).ToString();
                                    if (status == "Retry") {
                                        statusCode = Math.Max(statusCode, 1);
                                    } else if (status == "Ignore") {
                                        statusCode = Math.Max(statusCode, 2);
                                    } else if (status == "Abort") {
                                        //statusCode = Math.Max(statusCode, 10);
                                        return 10;
                                    }
                                }
                                if (status == "Run") {
                                    status = "Complete";
                                }
                            }
                        }
                    }
                }
                bar.Value++;
            }
            return statusCode;
        }



    }
    
}
