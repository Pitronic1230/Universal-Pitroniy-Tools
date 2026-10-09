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
            themesList = new ListBox();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // themesList
            // 
            themesList.FormattingEnabled = true;
            themesList.Location = new Point(12, 12);
            themesList.Name = "themesList";
            themesList.Size = new Size(458, 184);
            themesList.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(376, 212);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // DeleteThemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(deleteButton);
            Controls.Add(themesList);
            Name = "DeleteThemeForm";
            Text = "DeleteThemeForm";
            Load += DeleteThemeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox themesList;
        private Button deleteButton;
    }
}