namespace MusicManager {
    partial class MusicManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.folderBrowse = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.folderEntry = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ID3rename = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.patternReplaceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID3Progress = new System.Windows.Forms.ProgressBar();
            this.ID3Status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.validTags = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patternList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID3Options = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ID3MaxDepth = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ID3FolderSeparator = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ID3ArtistSeparator = new System.Windows.Forms.TextBox();
            this.ID3Overwrite = new System.Windows.Forms.CheckBox();
            this.unfilterButton = new System.Windows.Forms.CheckBox();
            this.ID3UnicodeReplace = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.replacePattern = new System.Windows.Forms.TextBox();
            this.regexRename = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.topCopy = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.copyContaining = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.copyToFolder = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ID3rename.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ID3Options.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID3MaxDepth)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.regexRename.SuspendLayout();
            this.topCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowse
            // 
            this.folderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderBrowse.Location = new System.Drawing.Point(553, 8);
            this.folderBrowse.Name = "folderBrowse";
            this.folderBrowse.Size = new System.Drawing.Size(59, 27);
            this.folderBrowse.TabIndex = 1;
            this.folderBrowse.Text = "Browse...";
            this.folderBrowse.UseVisualStyleBackColor = true;
            this.folderBrowse.Click += new System.EventHandler(this.folderBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.MaximumSize = new System.Drawing.Size(900, 900);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target folder:";
            // 
            // folderEntry
            // 
            this.folderEntry.AllowDrop = true;
            this.folderEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderEntry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.folderEntry.DropDownHeight = 1;
            this.folderEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.folderEntry.FormattingEnabled = true;
            this.folderEntry.IntegralHeight = false;
            this.folderEntry.Location = new System.Drawing.Point(102, 12);
            this.folderEntry.MaxDropDownItems = 20;
            this.folderEntry.Name = "folderEntry";
            this.folderEntry.Size = new System.Drawing.Size(445, 21);
            this.folderEntry.TabIndex = 0;
            this.folderEntry.Text = ".\\";
            this.folderEntry.SelectedIndexChanged += new System.EventHandler(this.folderEntry_SelectedIndexChanged);
            this.folderEntry.SelectedValueChanged += new System.EventHandler(this.folderEntry_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ID3rename);
            this.tabControl1.Controls.Add(this.regexRename);
            this.tabControl1.Controls.Add(this.topCopy);
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 273);
            this.tabControl1.TabIndex = 2;
            // 
            // ID3rename
            // 
            this.ID3rename.Controls.Add(this.tableLayoutPanel2);
            this.ID3rename.Controls.Add(this.tableLayoutPanel1);
            this.ID3rename.Controls.Add(this.label2);
            this.ID3rename.Controls.Add(this.replacePattern);
            this.ID3rename.Location = new System.Drawing.Point(4, 22);
            this.ID3rename.Name = "ID3rename";
            this.ID3rename.Padding = new System.Windows.Forms.Padding(3);
            this.ID3rename.Size = new System.Drawing.Size(616, 247);
            this.ID3rename.TabIndex = 0;
            this.ID3rename.Text = "Rename from ID3";
            this.ID3rename.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.patternReplaceButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(483, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(125, 203);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // patternReplaceButton
            // 
            this.patternReplaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternReplaceButton.Enabled = false;
            this.patternReplaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.patternReplaceButton.Location = new System.Drawing.Point(7, 7);
            this.patternReplaceButton.Name = "patternReplaceButton";
            this.patternReplaceButton.Size = new System.Drawing.Size(111, 34);
            this.patternReplaceButton.TabIndex = 5;
            this.patternReplaceButton.Text = "Rename files!";
            this.patternReplaceButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ID3Progress);
            this.panel1.Controls.Add(this.ID3Status);
            this.panel1.Location = new System.Drawing.Point(7, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 123);
            this.panel1.TabIndex = 7;
            // 
            // ID3Progress
            // 
            this.ID3Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ID3Progress.Location = new System.Drawing.Point(0, 100);
            this.ID3Progress.Maximum = 10;
            this.ID3Progress.Name = "ID3Progress";
            this.ID3Progress.Size = new System.Drawing.Size(113, 23);
            this.ID3Progress.TabIndex = 8;
            // 
            // ID3Status
            // 
            this.ID3Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ID3Status.Location = new System.Drawing.Point(0, 0);
            this.ID3Status.Name = "ID3Status";
            this.ID3Status.Size = new System.Drawing.Size(113, 97);
            this.ID3Status.TabIndex = 7;
            this.ID3Status.Text = "No pattern selected";
            this.ID3Status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.validTags, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.patternList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ID3Options, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.00948F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.99052F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 203);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valid tags";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validTags
            // 
            this.validTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validTags.Location = new System.Drawing.Point(5, 42);
            this.validTags.Name = "validTags";
            this.validTags.ReadOnly = true;
            this.validTags.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.validTags.Size = new System.Drawing.Size(96, 156);
            this.validTags.TabIndex = 3;
            this.validTags.TabStop = false;
            this.validTags.Text = "<album>\n<artists>\n<firstArtist>\n<title>\n<track>\n<year>\n<firstPerformer>\n<performe" +
    "rs>";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Common patterns";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patternList
            // 
            this.patternList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternList.FormattingEnabled = true;
            this.patternList.IntegralHeight = false;
            this.patternList.Items.AddRange(new object[] {
            "<title>",
            "<firstPerformer> - <title>",
            "<performers> - <title>",
            "<firstArtist> - <title>",
            "<artists> - <title>",
            "<album> - <title>",
            "<track> - <title>"});
            this.patternList.Location = new System.Drawing.Point(109, 42);
            this.patternList.Name = "patternList";
            this.patternList.Size = new System.Drawing.Size(129, 156);
            this.patternList.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Options";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID3Options
            // 
            this.ID3Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID3Options.Controls.Add(this.panel2);
            this.ID3Options.Controls.Add(this.panel3);
            this.ID3Options.Controls.Add(this.panel5);
            this.ID3Options.Controls.Add(this.ID3Overwrite);
            this.ID3Options.Controls.Add(this.unfilterButton);
            this.ID3Options.Controls.Add(this.ID3UnicodeReplace);
            this.ID3Options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ID3Options.Location = new System.Drawing.Point(246, 42);
            this.ID3Options.Name = "ID3Options";
            this.ID3Options.Size = new System.Drawing.Size(215, 156);
            this.ID3Options.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ID3MaxDepth);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 21);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(45, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Max depth";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID3MaxDepth
            // 
            this.ID3MaxDepth.Dock = System.Windows.Forms.DockStyle.Left;
            this.ID3MaxDepth.Location = new System.Drawing.Point(0, 0);
            this.ID3MaxDepth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ID3MaxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ID3MaxDepth.Name = "ID3MaxDepth";
            this.ID3MaxDepth.Size = new System.Drawing.Size(39, 20);
            this.ID3MaxDepth.TabIndex = 4;
            this.ID3MaxDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.ID3FolderSeparator);
            this.panel3.Location = new System.Drawing.Point(3, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 23);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Folder separator";
            // 
            // ID3FolderSeparator
            // 
            this.ID3FolderSeparator.Location = new System.Drawing.Point(0, 0);
            this.ID3FolderSeparator.MaxLength = 1;
            this.ID3FolderSeparator.Name = "ID3FolderSeparator";
            this.ID3FolderSeparator.Size = new System.Drawing.Size(26, 20);
            this.ID3FolderSeparator.TabIndex = 0;
            this.ID3FolderSeparator.Text = "\\";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.ID3ArtistSeparator);
            this.panel5.Location = new System.Drawing.Point(3, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 23);
            this.panel5.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Artist separator";
            // 
            // ID3ArtistSeparator
            // 
            this.ID3ArtistSeparator.Location = new System.Drawing.Point(0, 0);
            this.ID3ArtistSeparator.MaxLength = 32;
            this.ID3ArtistSeparator.Name = "ID3ArtistSeparator";
            this.ID3ArtistSeparator.Size = new System.Drawing.Size(46, 20);
            this.ID3ArtistSeparator.TabIndex = 0;
            this.ID3ArtistSeparator.Text = ", ";
            // 
            // ID3Overwrite
            // 
            this.ID3Overwrite.AutoSize = true;
            this.ID3Overwrite.Location = new System.Drawing.Point(3, 88);
            this.ID3Overwrite.Name = "ID3Overwrite";
            this.ID3Overwrite.Size = new System.Drawing.Size(144, 17);
            this.ID3Overwrite.TabIndex = 1;
            this.ID3Overwrite.Text = "Overwrite while renaming";
            this.ID3Overwrite.UseVisualStyleBackColor = true;
            // 
            // unfilterButton
            // 
            this.unfilterButton.AutoSize = true;
            this.unfilterButton.Checked = true;
            this.unfilterButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unfilterButton.Location = new System.Drawing.Point(3, 111);
            this.unfilterButton.Name = "unfilterButton";
            this.unfilterButton.Size = new System.Drawing.Size(158, 17);
            this.unfilterButton.TabIndex = 4;
            this.unfilterButton.Text = "Move all files to target folder";
            this.unfilterButton.UseVisualStyleBackColor = true;
            this.unfilterButton.CheckedChanged += new System.EventHandler(this.unfilterButton_CheckedChanged);
            // 
            // ID3UnicodeReplace
            // 
            this.ID3UnicodeReplace.AutoSize = true;
            this.ID3UnicodeReplace.Checked = true;
            this.ID3UnicodeReplace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ID3UnicodeReplace.Location = new System.Drawing.Point(3, 134);
            this.ID3UnicodeReplace.Name = "ID3UnicodeReplace";
            this.ID3UnicodeReplace.Size = new System.Drawing.Size(194, 17);
            this.ID3UnicodeReplace.TabIndex = 5;
            this.ID3UnicodeReplace.Text = "Illegal characters in path -> unicode";
            this.ID3UnicodeReplace.UseVisualStyleBackColor = true;
            this.ID3UnicodeReplace.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.MinimumSize = new System.Drawing.Size(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File name pattern:";
            // 
            // replacePattern
            // 
            this.replacePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replacePattern.Location = new System.Drawing.Point(118, 11);
            this.replacePattern.Name = "replacePattern";
            this.replacePattern.Size = new System.Drawing.Size(490, 20);
            this.replacePattern.TabIndex = 4;
            // 
            // regexRename
            // 
            this.regexRename.Controls.Add(this.label11);
            this.regexRename.Controls.Add(this.label9);
            this.regexRename.Location = new System.Drawing.Point(4, 22);
            this.regexRename.Name = "regexRename";
            this.regexRename.Padding = new System.Windows.Forms.Padding(3);
            this.regexRename.Size = new System.Drawing.Size(616, 247);
            this.regexRename.TabIndex = 1;
            this.regexRename.Text = "Rename from RegEx";
            this.regexRename.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(3, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(610, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "but you really don\'t.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(610, 241);
            this.label9.TabIndex = 0;
            this.label9.Text = "Right now you might think that you want to use RegEx for renaming files...";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topCopy
            // 
            this.topCopy.Controls.Add(this.copyToFolder);
            this.topCopy.Controls.Add(this.label13);
            this.topCopy.Controls.Add(this.copyContaining);
            this.topCopy.Controls.Add(this.label12);
            this.topCopy.Location = new System.Drawing.Point(4, 22);
            this.topCopy.Name = "topCopy";
            this.topCopy.Padding = new System.Windows.Forms.Padding(3);
            this.topCopy.Size = new System.Drawing.Size(616, 247);
            this.topCopy.TabIndex = 2;
            this.topCopy.Text = "TOP Cop";
            this.topCopy.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(8, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "To folder: ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // copyContaining
            // 
            this.copyContaining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyContaining.Location = new System.Drawing.Point(151, 12);
            this.copyContaining.Name = "copyContaining";
            this.copyContaining.Size = new System.Drawing.Size(457, 20);
            this.copyContaining.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(8, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Copy folders containing:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // copyToFolder
            // 
            this.copyToFolder.Location = new System.Drawing.Point(75, 39);
            this.copyToFolder.Name = "copyToFolder";
            this.copyToFolder.Size = new System.Drawing.Size(533, 20);
            this.copyToFolder.TabIndex = 3;
            // 
            // MusicManager
            // 
            this.ClientSize = new System.Drawing.Size(624, 322);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.folderEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderBrowse);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MusicManager";
            this.Text = "Glosb Music Tool";
            this.tabControl1.ResumeLayout(false);
            this.ID3rename.ResumeLayout(false);
            this.ID3rename.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ID3Options.ResumeLayout(false);
            this.ID3Options.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ID3MaxDepth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.regexRename.ResumeLayout(false);
            this.topCopy.ResumeLayout(false);
            this.topCopy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox folderEntry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ID3rename;
        private System.Windows.Forms.TabPage regexRename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox replacePattern;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox validTags;
        private System.Windows.Forms.Button patternReplaceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox patternList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ID3Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel ID3Options;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar ID3Progress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ID3Overwrite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID3FolderSeparator;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ID3ArtistSeparator;
        private System.Windows.Forms.NumericUpDown ID3MaxDepth;
        private System.Windows.Forms.CheckBox unfilterButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ID3UnicodeReplace;
        private System.Windows.Forms.TabPage topCopy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox copyContaining;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox copyToFolder;
    }
}

