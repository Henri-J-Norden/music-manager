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
using TagLib.Id3v2;

namespace MusicManager {
    public partial class MusicManager : Form {
        char[] folderSplitChars = new char[] { '\\', '/' };
        string[] folderNavKeys = new string[] { "Up", "Down" };
        string driveFolder = "<System>";
        int dropDownHeight = 300;


        public MusicManager() {
            InitializeComponent();
            folderEntry.KeyUp += folderEntry_KeyPress;
            folderEntry.SelectionChangeCommitted += folderEntry_SelectionCommitted;
            updateFolderEntryDirs(Directory.GetCurrentDirectory() + "\\", false);
            folderEntry.DroppedDown = false;
            folderEntry.DropDownHeight = dropDownHeight;
            folderEntry.Focus();
        }

        /// <summary>
        /// selection changed = highlighted value
        /// </summary>
        private void folderEntry_SelectionChanged(object sender, EventArgs e) { 
            folderEntry.DroppedDown = true;
        }
        /// <summary>
        /// selection committed = highlighted value selected
        /// </summary>
        private void folderEntry_SelectionCommitted(object sender, EventArgs e) { 
            updateFolderEntryDirs(folderEntry.SelectedValue.ToString());
        }

        /// <summary>
        /// Event handler to catch every keypress while focused on the folderEntry combobox
        /// </summary>
        private void folderEntry_KeyPress(object sender, KeyEventArgs e) {
            string keys = e.KeyData.ToString();
            if (keys.Contains("Up") || keys.Contains("Down")) { //ignore browsing the list up and down
                return;
            } else if (keys.Contains("Return") || keys.Contains("Escape")) { //confirm selection with ESC/enter, move to next field --- Doesn't work well
                updateFolderEntryDirs(folderEntry.SelectedValue.ToString(), false);
                folderEntry.Select(folderEntry.Text.Length - 1, 0);
                tabControl1.Focus();
                folderEntry.DroppedDown = false;
            } else { //on any other keypress, reload the directory list
                updateFolderEntryDirs(folderEntry.Text);
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

            //events are removed and readded later so they don't get triggered like Ingmar
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
    }
}
