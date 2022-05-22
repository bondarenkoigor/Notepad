namespace buttons
{
    partial class FindForm
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
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.WhatLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.UpRadioButton = new System.Windows.Forms.RadioButton();
            this.DownRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(42, 12);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(205, 20);
            this.FindTextBox.TabIndex = 0;
            // 
            // WhatLabel
            // 
            this.WhatLabel.AutoSize = true;
            this.WhatLabel.Location = new System.Drawing.Point(7, 15);
            this.WhatLabel.Name = "WhatLabel";
            this.WhatLabel.Size = new System.Drawing.Size(29, 13);
            this.WhatLabel.TabIndex = 1;
            this.WhatLabel.Text = "Что:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(253, 10);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(93, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Найти Далее";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // UpRadioButton
            // 
            this.UpRadioButton.AutoSize = true;
            this.UpRadioButton.Location = new System.Drawing.Point(42, 38);
            this.UpRadioButton.Name = "UpRadioButton";
            this.UpRadioButton.Size = new System.Drawing.Size(55, 17);
            this.UpRadioButton.TabIndex = 3;
            this.UpRadioButton.Text = "Вверх";
            this.UpRadioButton.UseVisualStyleBackColor = true;
            // 
            // DownRadioButton
            // 
            this.DownRadioButton.AutoSize = true;
            this.DownRadioButton.Checked = true;
            this.DownRadioButton.Location = new System.Drawing.Point(42, 62);
            this.DownRadioButton.Name = "DownRadioButton";
            this.DownRadioButton.Size = new System.Drawing.Size(50, 17);
            this.DownRadioButton.TabIndex = 4;
            this.DownRadioButton.TabStop = true;
            this.DownRadioButton.Text = "Вниз";
            this.DownRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 106);
            this.Controls.Add(this.DownRadioButton);
            this.Controls.Add(this.UpRadioButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.WhatLabel);
            this.Controls.Add(this.FindTextBox);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WhatLabel;
        public System.Windows.Forms.TextBox FindTextBox;
        public System.Windows.Forms.Button FindButton;
        public System.Windows.Forms.RadioButton UpRadioButton;
        public System.Windows.Forms.RadioButton DownRadioButton;
    }
}