namespace buttons
{
    partial class GoToForm
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
            this.StringNumTextBox = new System.Windows.Forms.TextBox();
            this.StringNumLabel = new System.Windows.Forms.Label();
            this.GoToButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StringNumTextBox
            // 
            this.StringNumTextBox.Location = new System.Drawing.Point(12, 46);
            this.StringNumTextBox.Name = "StringNumTextBox";
            this.StringNumTextBox.Size = new System.Drawing.Size(241, 20);
            this.StringNumTextBox.TabIndex = 0;
            // 
            // StringNumLabel
            // 
            this.StringNumLabel.AutoSize = true;
            this.StringNumLabel.Location = new System.Drawing.Point(13, 27);
            this.StringNumLabel.Name = "StringNumLabel";
            this.StringNumLabel.Size = new System.Drawing.Size(82, 13);
            this.StringNumLabel.TabIndex = 1;
            this.StringNumLabel.Text = "Номер строки:";
            // 
            // GoToButton
            // 
            this.GoToButton.Location = new System.Drawing.Point(178, 72);
            this.GoToButton.Name = "GoToButton";
            this.GoToButton.Size = new System.Drawing.Size(75, 23);
            this.GoToButton.TabIndex = 2;
            this.GoToButton.Text = "Перейти";
            this.GoToButton.UseVisualStyleBackColor = true;
            this.GoToButton.Click += new System.EventHandler(this.GoToButton_Click);
            // 
            // GoToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 98);
            this.Controls.Add(this.GoToButton);
            this.Controls.Add(this.StringNumLabel);
            this.Controls.Add(this.StringNumTextBox);
            this.Name = "GoToForm";
            this.ShowIcon = false;
            this.Text = "Перейти...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringNumTextBox;
        private System.Windows.Forms.Label StringNumLabel;

        public int ReturnValue = -1;
        private System.Windows.Forms.Button GoToButton;
    }
}