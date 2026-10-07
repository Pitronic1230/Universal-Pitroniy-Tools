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
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            filesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filesTable).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(filesPage);
            tabControl1.Controls.Add(statusPage);
            tabControl1.Controls.Add(controlPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 453);
            tabControl1.TabIndex = 0;
            // 
            // filesPage
            // 
            filesPage.Controls.Add(splitContainer1);
            filesPage.Location = new Point(4, 29);
            filesPage.Name = "filesPage";
            filesPage.Padding = new Padding(3);
            filesPage.Size = new Size(792, 420);
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
            splitContainer1.Size = new Size(786, 414);
            splitContainer1.SplitterDistance = 49;
            splitContainer1.TabIndex = 0;
            // 
            // AddFile_button
            // 
            AddFile_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddFile_button.Location = new Point(5, 3);
            AddFile_button.Name = "AddFile_button";
            AddFile_button.Size = new Size(778, 43);
            AddFile_button.TabIndex = 0;
            AddFile_button.Text = "Add File";
            AddFile_button.UseVisualStyleBackColor = true;
            AddFile_button.Click += AddFile_button_Click;
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
            filesTable.Size = new Size(786, 361);
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
            statusPage.Size = new Size(792, 420);
            statusPage.TabIndex = 1;
            statusPage.Text = "Status";
            statusPage.UseVisualStyleBackColor = true;
            // 
            // controlPage
            // 
            controlPage.Location = new Point(4, 29);
            controlPage.Name = "controlPage";
            controlPage.Size = new Size(792, 420);
            controlPage.TabIndex = 2;
            controlPage.Text = "Control";
            controlPage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UniversalPitroniyTool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage filesPage;
        private TabPage statusPage;
        private SplitContainer splitContainer1;
        private Button AddFile_button;
        private OpenFileDialog openFileDialog1;
        private DataGridView filesTable;
        private DataGridViewTextBoxColumn batTableFile;
        private DataGridViewTextBoxColumn batTableFilePath;
        private DataGridViewButtonColumn batTableRun;
        private DataGridViewButtonColumn batTableDelete;
        private TabPage controlPage;
    }
}
