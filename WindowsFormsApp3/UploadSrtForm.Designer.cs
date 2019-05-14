namespace WindowsFormsApp3
{
    partial class UploadSrtForm
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
            this.srtFileTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.tvShowComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // srtFileTextBox
            // 
            this.srtFileTextBox.Location = new System.Drawing.Point(12, 46);
            this.srtFileTextBox.Name = "srtFileTextBox";
            this.srtFileTextBox.Size = new System.Drawing.Size(392, 20);
            this.srtFileTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(410, 46);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(224, 72);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 2;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // tvShowComboBox
            // 
            this.tvShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tvShowComboBox.FormattingEnabled = true;
            this.tvShowComboBox.Items.AddRange(new object[] {
            "权力的游戏",
            "纸牌屋",
            "复仇者联盟"});
            this.tvShowComboBox.Location = new System.Drawing.Point(12, 12);
            this.tvShowComboBox.Name = "tvShowComboBox";
            this.tvShowComboBox.Size = new System.Drawing.Size(473, 21);
            this.tvShowComboBox.TabIndex = 3;
            // 
            // UploadSrtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 109);
            this.Controls.Add(this.tvShowComboBox);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.srtFileTextBox);
            this.Name = "UploadSrtForm";
            this.Text = "Upload Srt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srtFileTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.ComboBox tvShowComboBox;
    }
}

