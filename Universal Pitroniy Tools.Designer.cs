namespace Universal_Pitroniy_Tools
{
    partial class UniversalPitroniyTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversalPitroniyTool));
            tabControl1 = new TabControl();
            filesPage = new TabPage();
            splitContainer1 = new SplitContainer();
            AddFile_button = new Button();
            filesTable = new DataGridView();
            batTableFile = new DataGridViewTextBoxColumn();
            batTableFilePath = new DataGridViewTextBoxColumn();
            batTableRun = new DataGridViewButtonColumn();
            batTableDelete = new DataGridViewButtonColumn();
            statusPage = new TabPage();
            controlPage = new TabPage();
            settingsPage = new TabPage();
            themeGroupBox = new GroupBox();
            deleteThemeButton = new Button();
            addThemeButton = new Button();
            themeSelectorLabel = new Label();
            themeSelector = new ComboBox();
            openFileDialog = new OpenFileDialog();
            openThemeDialog = new OpenFileDialog();
            tabControl1.SuspendLayout();
            filesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filesTable).BeginInit();
            settingsPage.SuspendLayout();
            themeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(filesPage);
            tabControl1.Controls.Add(statusPage);
            tabControl1.Controls.Add(controlPage);
            tabControl1.Controls.Add(settingsPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 453);
            tabControl1.TabIndex = 0;
            // 
            // filesPage
            // 
            filesPage.Controls.Add(splitContainer1);
            filesPage.Location = new Point(4, 29);
            filesPage.Name = "filesPage";
            filesPage.Padding = new Padding(3);
            filesPage.Size = new Size(774, 420);
            filesPage.TabIndex = 0;
            filesPage.Text = "Files";
            filesPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(AddFile_button);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(filesTable);
            splitContainer1.Size = new Size(768, 414);
            splitContainer1.SplitterDistance = 49;
            splitContainer1.TabIndex = 0;
            // 
            // AddFile_button
            // 
            AddFile_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddFile_button.Location = new Point(5, 3);
            AddFile_button.Name = "AddFile_button";
            AddFile_button.Size = new Size(760, 43);
            AddFile_button.TabIndex = 0;
            AddFile_button.Text = "Add File";
            AddFile_button.UseVisualStyleBackColor = true;
            AddFile_button.Click += AddFileButton_Click;
            // 
            // filesTable
            // 
            filesTable.AllowUserToAddRows = false;
            filesTable.AllowUserToDeleteRows = false;
            filesTable.AllowUserToOrderColumns = true;
            filesTable.AllowUserToResizeRows = false;
            filesTable.BackgroundColor = SystemColors.Control;
            filesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filesTable.Columns.AddRange(new DataGridViewColumn[] { batTableFile, batTableFilePath, batTableRun, batTableDelete });
            filesTable.Dock = DockStyle.Fill;
            filesTable.Location = new Point(0, 0);
            filesTable.Name = "filesTable";
            filesTable.RowHeadersWidth = 51;
            filesTable.Size = new Size(768, 361);
            filesTable.TabIndex = 0;
            filesTable.CellContentClick += FilesTable_CellContentClick;
            // 
            // batTableFile
            // 
            batTableFile.HeaderText = "File";
            batTableFile.MinimumWidth = 6;
            batTableFile.Name = "batTableFile";
            batTableFile.Resizable = DataGridViewTriState.True;
            batTableFile.Width = 61;
            // 
            // batTableFilePath
            // 
            batTableFilePath.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            batTableFilePath.FillWeight = 167.741959F;
            batTableFilePath.HeaderText = "Path";
            batTableFilePath.MinimumWidth = 6;
            batTableFilePath.Name = "batTableFilePath";
            // 
            // batTableRun
            // 
            batTableRun.HeaderText = "Run";
            batTableRun.MinimumWidth = 6;
            batTableRun.Name = "batTableRun";
            batTableRun.Resizable = DataGridViewTriState.False;
            batTableRun.SortMode = DataGridViewColumnSortMode.Automatic;
            batTableRun.Width = 60;
            // 
            // batTableDelete
            // 
            batTableDelete.HeaderText = "Delete";
            batTableDelete.MinimumWidth = 6;
            batTableDelete.Name = "batTableDelete";
            batTableDelete.Resizable = DataGridViewTriState.False;
            batTableDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            batTableDelete.Width = 60;
            // 
            // statusPage
            // 
            statusPage.Location = new Point(4, 29);
            statusPage.Name = "statusPage";
            statusPage.Padding = new Padding(3);
            statusPage.Size = new Size(774, 420);
            statusPage.TabIndex = 1;
            statusPage.Text = "Status";
            statusPage.UseVisualStyleBackColor = true;
            // 
            // controlPage
            // 
            controlPage.Location = new Point(4, 29);
            controlPage.Name = "controlPage";
            controlPage.Size = new Size(774, 420);
            controlPage.TabIndex = 2;
            controlPage.Text = "Control";
            controlPage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            settingsPage.Controls.Add(themeGroupBox);
            settingsPage.Location = new Point(4, 29);
            settingsPage.Name = "settingsPage";
            settingsPage.Size = new Size(774, 420);
            settingsPage.TabIndex = 3;
            settingsPage.Text = "Settings";
            settingsPage.UseVisualStyleBackColor = true;
            // 
            // themeGroupBox
            // 
            themeGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            themeGroupBox.Controls.Add(deleteThemeButton);
            themeGroupBox.Controls.Add(addThemeButton);
            themeGroupBox.Controls.Add(themeSelectorLabel);
            themeGroupBox.Controls.Add(themeSelector);
            themeGroupBox.Location = new Point(8, 15);
            themeGroupBox.Name = "themeGroupBox";
            themeGroupBox.Size = new Size(758, 125);
            themeGroupBox.TabIndex = 2;
            themeGroupBox.TabStop = false;
            themeGroupBox.Text = "Theme";
            // 
            // deleteThemeButton
            // 
            deleteThemeButton.AutoSize = true;
            deleteThemeButton.Location = new Point(6, 82);
            deleteThemeButton.Name = "deleteThemeButton";
            deleteThemeButton.Size = new Size(109, 30);
            deleteThemeButton.TabIndex = 3;
            deleteThemeButton.Text = "Delete theme";
            deleteThemeButton.UseVisualStyleBackColor = true;
            deleteThemeButton.Click += DeleteThemeButton_Click;
            // 
            // addThemeButton
            // 
            addThemeButton.AutoSize = true;
            addThemeButton.Location = new Point(6, 46);
            addThemeButton.Name = "addThemeButton";
            addThemeButton.Size = new Size(94, 30);
            addThemeButton.TabIndex = 2;
            addThemeButton.Text = "Add theme";
            addThemeButton.UseVisualStyleBackColor = true;
            addThemeButton.Click += AddThemeButton_Click;
            // 
            // themeSelectorLabel
            // 
            themeSelectorLabel.AutoSize = true;
            themeSelectorLabel.Location = new Point(6, 23);
            themeSelectorLabel.Name = "themeSelectorLabel";
            themeSelectorLabel.Size = new Size(95, 20);
            themeSelectorLabel.TabIndex = 1;
            themeSelectorLabel.Text = "Select theme";
            // 
            // themeSelector
            // 
            themeSelector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            themeSelector.FormattingEnabled = true;
            themeSelector.Location = new Point(452, 20);
            themeSelector.Name = "themeSelector";
            themeSelector.Size = new Size(300, 28);
            themeSelector.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // openThemeDialog
            // 
            openThemeDialog.FileName = "openFileDialog1";
            // 
            // UniversalPitroniyTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 200);
            Name = "UniversalPitroniyTool";
            Text = " Universal Pitroniy Tools";
            FormClosing += OnClosing;
            Load += OnLoad;
            tabControl1.ResumeLayout(false);
            filesPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filesTable).EndInit();
            settingsPage.ResumeLayout(false);
            themeGroupBox.ResumeLayout(false);
            themeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage filesPage;
        private TabPage statusPage;
        private SplitContainer splitContainer1;
        private Button AddFile_button;
        private OpenFileDialog openFileDialog;
        private DataGridView filesTable;
        private DataGridViewTextBoxColumn batTableFile;
        private DataGridViewTextBoxColumn batTableFilePath;
        private DataGridViewButtonColumn batTableRun;
        private DataGridViewButtonColumn batTableDelete;
        private TabPage controlPage;
        private TabPage settingsPage;
        private Label themeSelectorLabel;
        private GroupBox themeGroupBox;
        private Button addThemeButton;
        private OpenFileDialog openThemeDialog;
        private Button deleteThemeButton;
        internal ComboBox themeSelector;
    }
}
