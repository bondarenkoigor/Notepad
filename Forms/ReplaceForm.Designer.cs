namespace buttons
{
    partial class ReplaceForm
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
            this.WhatTextBox = new System.Windows.Forms.TextBox();
            this.WithTextBox = new System.Windows.Forms.TextBox();
            this.WhatLabel = new System.Windows.Forms.Label();
            this.WithLabel = new System.Windows.Forms.Label();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.ReplaceAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhatTextBox
            // 
            this.WhatTextBox.Location = new System.Drawing.Point(41, 12);
            this.WhatTextBox.Name = "WhatTextBox";
            this.WhatTextBox.Size = new System.Drawing.Size(261, 20);
            this.WhatTextBox.TabIndex = 0;
            // 
            // WithTextBox
            // 
            this.WithTextBox.Location = new System.Drawing.Point(41, 47);
            this.WithTextBox.Name = "WithTextBox";
            this.WithTextBox.Size = new System.Drawing.Size(261, 20);
            this.WithTextBox.TabIndex = 1;
            // 
            // WhatLabel
            // 
            this.WhatLabel.AutoSize = true;
            this.WhatLabel.Location = new System.Drawing.Point(2, 13);
            this.WhatLabel.Name = "WhatLabel";
            this.WhatLabel.Size = new System.Drawing.Size(29, 13);
            this.WhatLabel.TabIndex = 2;
            this.WhatLabel.Text = "Что:";
            // 
            // WithLabel
            // 
            this.WithLabel.AutoSize = true;
            this.WithLabel.Location = new System.Drawing.Point(3, 50);
            this.WithLabel.Name = "WithLabel";
            this.WithLabel.Size = new System.Drawing.Size(32, 13);
            this.WithLabel.TabIndex = 3;
            this.WithLabel.Text = "Чем:";
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(308, 8);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(91, 23);
            this.ReplaceButton.TabIndex = 4;
            this.ReplaceButton.Text = "Заменить";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            // 
            // ReplaceAllButton
            // 
            this.ReplaceAllButton.Location = new System.Drawing.Point(308, 44);
            this.ReplaceAllButton.Name = "ReplaceAllButton";
            this.ReplaceAllButton.Size = new System.Drawing.Size(91, 23);
            this.ReplaceAllButton.TabIndex = 5;
            this.ReplaceAllButton.Text = "Заменить все";
            this.ReplaceAllButton.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 94);
            this.Controls.Add(this.ReplaceAllButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.WithLabel);
            this.Controls.Add(this.WhatLabel);
            this.Controls.Add(this.WithTextBox);
            this.Controls.Add(this.WhatTextBox);
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.Text = "Заменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WhatLabel;
        private System.Windows.Forms.Label WithLabel;
        public System.Windows.Forms.TextBox WhatTextBox;
        public System.Windows.Forms.TextBox WithTextBox;
        public System.Windows.Forms.Button ReplaceButton;
        public System.Windows.Forms.Button ReplaceAllButton;
    }
}