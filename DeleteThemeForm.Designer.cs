namespace Universal_Pitroniy_Tools
{
    partial class DeleteThemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deleteThemeList = new ListBox();
            SuspendLayout();
            // 
            // deleteThemeList
            // 
            deleteThemeList.FormattingEnabled = true;
            deleteThemeList.Location = new Point(12, 12);
            deleteThemeList.Name = "deleteThemeList";
            deleteThemeList.Size = new Size(458, 224);
            deleteThemeList.TabIndex = 0;
            // 
            // DeleteThemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(deleteThemeList);
            Name = "DeleteThemeForm";
            Text = "DeleteThemeForm";
            Load += DeleteThemeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox deleteThemeList;
    }
}