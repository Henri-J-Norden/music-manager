using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MusicManager {
    public partial class MusicManager : Form {
        char[] folderSplitChars = new char[] { '\\', '/' };
        string[] folderNavKeys = new string[] { "Up", "Down" };
        string driveFolder = "<System>";
        int dropDownHeight = 300;
        TagManager tagMan = new TagManager();


        public MusicManager() {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource)) {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
            InitializeComponent();
            validTags.SelectAll();
            validTags.SelectionAlignment = HorizontalAlignment.Center;
            //folderEntry.KeyUp += folderEntry_KeyPress;
            //folderEntry.SelectionChangeCommitted += folderEntry_SelectionCommitted;
            updateFolderEntryDirs(Directory.GetCurrentDirectory() + "\\", false);
            folderEntry.DroppedDown = false;
            folderEntry.DropDownHeight = dropDownHeight;
            folderEntry.Focus();
            patternReplaceButton.Click += Click_patternReplaceButton;
            patternList.SelectedValueChanged += Selected_patternList;
            validTags.SelectionChanged += Selected_validTags;
            replacePattern.TextChanged += replacePatternValidator;
            replacePattern.TextChanged += TextChanged_replacePattern;
            folderEntry.LostFocus += LostFocus_folderEntry;
            folderEntry.GotFocus += GotFocus_folderEntry;
            LostFocus_folderEntry(null,null);

            //options
            ID3Overwrite.Click += (object o, EventArgs e) => { tagMan.overwrite = ID3Overwrite.Checked; };
            ID3ArtistSeparator.TextChanged += (object o, EventArgs e) => { tagMan.artistSeparator = ID3ArtistSeparator.Text; };
            ID3FolderSeparator.TextChanged += (object o, EventArgs e) => { tagMan.folderSeparator = ID3FolderSeparator.Text[0]; };
            ID3MaxDepth.ValueChanged += (object o, EventArgs e) => { tagMan.maxDepth = (int)ID3MaxDepth.Value; };
            ID3UnicodeReplace.CheckedChanged += (object o, EventArgs e) => { tagMan.unicodeReplace = ID3UnicodeReplace.Checked; };
            }

        private bool IsID3PatternValid() {
            int tagStart = replacePattern.Text.Count((char ch) => ch == '<');
            int tagEnd = replacePattern.Text.Count((char ch) => ch == '>');
            if (tagStart != tagEnd) {
                return false;
            }
            //List<string> patternTags = new List<string>();
            int tmp = 0;
            int tagCount = 0;
            foreach (string part in replacePattern.Text.Split("<>".ToCharArray(), StringSplitOptions.None)) {
                if (tmp % 2 == 1) {
                    Console.WriteLine(part);
                    foreach (string tag in validTags.Lines) {
                        if (tag.ToLower() == "<"+part.ToLower()+">") {
                            tagCount++;
                            break;
                        }
                    }
                }
                tmp++;
            }

            Console.WriteLine(tagCount.ToString() + ":" + tagStart.ToString());
            if (tagStart == tagCount) {
                return true;
            } else {
                return false;
            }
        }

        private void LostFocus_folderEntry(object sender, EventArgs e) {
            folderEntry.KeyUp -= folderEntry_KeyPress;
            folderEntry.SelectionChangeCommitted -= folderEntry_SelectionCommitted;
            folderEntry.SelectedIndexChanged -= folderEntry_SelectedIndexChanged;
            folderEntry.SelectedValueChanged -= folderEntry_SelectionChanged;
        }

        private void GotFocus_folderEntry(object sender, EventArgs e) {
            folderEntry.KeyUp += folderEntry_KeyPress;
            folderEntry.SelectionChangeCommitted += folderEntry_SelectionCommitted;
            folderEntry.SelectedIndexChanged += folderEntry_SelectedIndexChanged;
            folderEntry.SelectedValueChanged += folderEntry_SelectionChanged;
        }

        private void Click_patternReplaceButton(object sender, EventArgs e) {
            tagMan.directory = folderEntry.Text;
            tagMan.moveFilesToDirectory = unfilterButton.Checked;
            tagMan.pattern = replacePattern.Text;
            int result = tagMan.SetMP3Names(ID3Progress);
            if (result == 0) { //renaming succeeded
                ID3Status.Text = "Operation completed successfully!";
                ID3Status.ForeColor = Color.Green;
                Task.Delay(2000).ContinueWith((Task t) => { ID3Progress.Value = 0; }, TaskScheduler.FromCurrentSynchronizationContext());
            } else if (result == 10) { //aborted due to error
                ID3Status.Text = "Operation cancelled!";
                ID3Status.ForeColor = Color.Red;
            } else if (result == 2) { //error ignored
                ID3Status.Text = "Some files were not renamed due to an error!";
                ID3Status.ForeColor = Color.Red;
            }
        }

        private void TextChanged_replacePattern(object sender, EventArgs e) {
            patternList.SelectedValueChanged -= Selected_patternList;
            patternList.ClearSelected();
            patternList.SelectedValueChanged += Selected_patternList;
        }

        private void replacePatternValidator(object sender, EventArgs e) {
            if (replacePattern.Text == "") {
                ID3Status.Text = "No pattern selected";
                ID3Status.ForeColor = Color.Black;
                patternReplaceButton.Enabled = false;
            } else if (IsID3PatternValid()) {
                ID3Status.Text = "Valid pattern!";
                ID3Status.ForeColor = Color.Green;
                patternReplaceButton.Enabled = true;
            } else {
                ID3Status.Text = "Invalid pattern!";
                ID3Status.ForeColor = Color.Red;
                patternReplaceButton.Enabled = false;
            }
        }

        private void Selected_patternList(object sender, EventArgs e) {
            replacePattern.TextChanged -= TextChanged_replacePattern;
            replacePattern.Text = patternList.Text;
            replacePattern.TextChanged += TextChanged_replacePattern;
        }

        private void Selected_validTags(object sender, EventArgs e) {
            int line = validTags.GetLineFromCharIndex(validTags.SelectionStart);
            int lineStart = validTags.GetFirstCharIndexFromLine(line);
            validTags.Select(lineStart, validTags.Lines[line].Length);
        }

        /// <summary>
        /// selection changed = highlighted value
        /// </summary>
        private void folderEntry_SelectionChanged(object sender, EventArgs e) { 
            folderEntry.DroppedDown = true;
            folderEntry.SelectionStart = folderEntry.Text.Length;
        }
        /// <summary>
        /// selection committed = highlighted value selected
        /// </summary>
        private void folderEntry_SelectionCommitted(object sender, EventArgs e) { 
            updateFolderEntryDirs(folderEntry.SelectedValue.ToString(), false);
            
        }

        /// <summary>
        /// Event handler to catch every keypress while focused on the folderEntry combobox
        /// </summary>
        string[] voidKeys = new string[] { "Up", "Down", "Left" };//, "Shift", "Control", "Back", "Delete" };
        private void folderEntry_KeyPress(object sender, KeyEventArgs e) {
            string keys = e.KeyData.ToString();
            foreach (string key in voidKeys) {
                if (keys.Contains(key)) { //ignore the specified keys
                    return;
                }
            }
            if (keys.Contains("Right") && folderEntry.SelectionStart + folderEntry.SelectionLength != folderEntry.Text.Length) { //allow for moving right within the text
                return;
            } else if (keys.Contains("Return") || keys.Contains("Escape")) { //confirm selection with ESC/enter, move to next field --- Doesn't work well
                updateFolderEntryDirs(folderEntry.SelectedValue.ToString(), false);
                folderEntry.SelectionStart = folderEntry.Text.Length;
                //tabControl1.Focus();
                folderEntry.DroppedDown = false;
            } else if (folderEntry.SelectedIndex == 1 && keys.Contains("Right")) { //if the current path is selected in the dropdown and right arrow is pressed, toggles the dropdown's state
                folderEntry.DroppedDown = !folderEntry.DroppedDown;
                folderEntry.SelectionStart = folderEntry.Text.Length;
            } else if (keys.Contains("Right")) { //reload the directory list if right arrow is pressed
                bool dropped = folderEntry.DroppedDown;
                updateFolderEntryDirs(folderEntry.Text);
                if (dropped) { //renew the dropdown so it resizes
                    folderEntry.DroppedDown = false;
                    folderEntry.DroppedDown = true;
                }
                folderEntry.SelectionStart = 0;
                //folderEntry.SelectionLength = selLength;
            } else {
                int selStart = folderEntry.SelectionStart;
                int selLength = folderEntry.SelectionLength;
                bool dropped = folderEntry.DroppedDown;
                //Console.WriteLine(folderEntry.Height);
                //string savedText = folderEntry.Text;
                /*if (folderEntry.Height < dropDownHeight) { //resizing the dropdown just doesn't work
                    ComboBox.ObjectCollection list = folderEntry.Items;
                    int i = 0;
                    folderEntry.DataSource = null;
                    while (folderEntry.Height + folderEntry.ItemHeight*i < dropDownHeight) {
                        i++;
                        list.Add("");
                    }
                    folderEntry.DataSource = list;
                    if (dropped) {
                        folderEntry.DroppedDown = false;
                        folderEntry.DroppedDown = true;
                    }
                }*/
                //folderEntry.Text = savedText;
                updateFolderEntryDirs(folderEntry.Text, dropped);
                folderEntry.SelectionStart = selStart;
                folderEntry.SelectionLength = selLength;
            }
        }
        

        /// <summary>
        /// Reads the subdirectories of newDir and updates the folderEntry combobox
        /// </summary>
        /// <param name="newDir">The path of the directory from which to get the subfolders from. Must end with '\'</param>
        /// <param name="dropDown">Whether to deploy the drop down menu after updating --- often won't work by itself</param>
        private void updateFolderEntryDirs(string newDir, bool dropDown = true) { 
            string curDir = "";
            string parentDir = "";
            int[] selection = new int[2] { folderEntry.SelectionStart, folderEntry.SelectionLength };
            string[] curDirSplit = newDir.Split(folderSplitChars);
            for (int i = 0; i < curDirSplit.Length-1; i++) { //gets the current directory and its parent directory
                curDir += curDirSplit[i] + "\\";
                if (i < curDirSplit.Length - 2) {
                    parentDir += curDirSplit[i] + "\\";
                }
            }
            if (parentDir == "") { //if no parent directory exists, show system drives instead
                parentDir = driveFolder;
            }

            string[] dirs = new string[] { parentDir, newDir }; //array of direstories to display on the combobox
            try {
                string[] sysDirs;
                if (newDir == driveFolder) { //shows system drives
                    sysDirs = Directory.GetLogicalDrives();
                    for (int i = 0; i < sysDirs.Length; i++) {
                        sysDirs[i] = sysDirs[i].TrimEnd('\\');
                    }
                } else { //gets subdirectories
                    sysDirs = Directory.GetDirectories(curDir);
                }
                //--- merges the new "sysDirs" array into the main "dirs" array ---
                int dirsIndex = dirs.Length;
                Array.Resize<string>(ref dirs, sysDirs.Length + dirs.Length);
                for (int i = 0; i < sysDirs.Length; i++) {
                    if (sysDirs[i].Contains(newDir) || newDir == driveFolder) {
                        dirs[dirsIndex] = sysDirs[i] + "\\";
                        dirsIndex++;
                    }
                }
                //------
                                
            } catch (Exception e) when (e is ArgumentException || e is DirectoryNotFoundException) { }

            if (!dropDown) { //attempts to hide the drop down menu as much as possible, since setting the data source opens it
                folderEntry.DropDownHeight = 1;
            }
            folderEntry.DataSource = dirs;

            //events are removed and readded later so they don't get triggered 
            folderEntry.SelectedValueChanged -= folderEntry_SelectionChanged;
            folderEntry.SelectionChangeCommitted -= folderEntry_SelectionCommitted;
            folderEntry.DropDownHeight = dropDownHeight;
            folderEntry.SelectedItem = newDir;
            if (!dropDown) {
                folderEntry.DroppedDown = false;
            } else {
                folderEntry.Select(selection[0], selection[1]);
            }
            folderEntry.SelectedValueChanged += folderEntry_SelectionChanged;
            folderEntry.SelectionChangeCommitted += folderEntry_SelectionCommitted;
        }

        /// <summary>
        /// Event handler to display the shit built-in folder browser
        /// </summary>
        private void folderBrowse_Click(object sender, EventArgs e) {
            fbd.ShowDialog();
            if (fbd.SelectedPath != "") { //if the folder selection is cancelled, the browser returns a null string
                string path = fbd.SelectedPath;
                if (path[path.Length - 1] != '\\') { //ensures that there won't be too many \'s
                    path += "\\";
                }
                updateFolderEntryDirs(path, false);
            }
        }

        

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {
                    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void folderEntry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }

        private void unfilterButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void label13_Click(object sender, EventArgs e) {

        }
    }
}
