using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.Text)) File.WriteAllText(this.Text, richTextBox.Text);
            else SaveAsToolStripMenuItem_Click(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = ".txt|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(dialog.FileName + ".txt", this.richTextBox.Text);
                        this.Text = dialog.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("error");
                    }
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.richTextBox.Text = File.ReadAllText(dialog.FileName);
                        this.Text = dialog.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("error");
                    }
                }
            }
        }

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Блокнот";
            this.richTextBox.Text = "";
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
            => this.richTextBox.Undo();

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
            => this.richTextBox.Cut();

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
            => this.richTextBox.Copy();

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
            => this.richTextBox.Paste();

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
            => this.richTextBox.SelectedText = String.Empty;

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
            => this.richTextBox.SelectAll();

        private void TimeAndDateToolStripMenuItem_Click(object sender, EventArgs e)
            => this.richTextBox.AppendText(DateTime.Now.ToString());

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
            => (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;

        private void IncreaseSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextBox.Font.Size <= 50)
                this.richTextBox.Font = new System.Drawing.Font("Regular", this.richTextBox.Font.Size + 1);
        }

        private void DecreaseSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextBox.Font.Size > 1)
                this.richTextBox.Font = new System.Drawing.Font("Regular", this.richTextBox.Font.Size - 1);
        }

        private void DefaultSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox.Font = new System.Drawing.Font("Regular", 12);
        }

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm frm = new GoToForm();
            frm.Show();
            frm.FormClosing += Frm_FormClosing;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((sender as GoToForm).DialogResult != DialogResult.OK) return;
            int pos = (sender as GoToForm).ReturnValue;
            string[] lines = richTextBox.Text.Split('\n');
            if (pos > lines.Length || pos <= 0)
            {
                MessageBox.Show("неверный ввод");
                return;
            }

            int offset = 0;
            for (int i = 0; i < pos; i++)
            {
                offset += lines[i].Length + 1;
            }
            this.richTextBox.Select(offset - 1, 0);
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finder = new FindForm();
            Finder.Show();
            Finder.FindButton.Click += FindButton_Click;
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            RememberedFindTextBox = Finder.FindTextBox.Text;

            this.Select();
            this.richTextBox.Select();
            if (this.Finder.DownRadioButton.Checked)
                //ind = this.richTextBox.Text.IndexOf(Finder.FindTextBox.Text, this.richTextBox.SelectionStart + this.richTextBox.SelectionLength);
                FindNextToolStripMenuItem_Click(sender, e);
            else
                //ind = this.richTextBox.Text.LastIndexOf(Finder.FindTextBox.Text, this.richTextBox.SelectionStart);
                FindPreviousToolStripMenuItem_Click(sender, e);

        }

        private FindForm Finder;
        string RememberedFindTextBox = String.Empty;

        private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RememberedFindTextBox != String.Empty)
                try
                {
                    this.richTextBox.SelectionStart = this.richTextBox.Text.IndexOf(RememberedFindTextBox, this.richTextBox.SelectionStart + this.richTextBox.SelectionLength);
                    this.richTextBox.SelectionLength = RememberedFindTextBox.Length;
                }
                catch
                {
                    MessageBox.Show("Не найдено совпадений");
                }
            else if (sender is Button == false)
                FindToolStripMenuItem_Click(sender, e);
        }

        private void FindPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RememberedFindTextBox != String.Empty)
                try
                {
                    this.richTextBox.SelectionStart = this.richTextBox.Text.LastIndexOf(RememberedFindTextBox, this.richTextBox.SelectionStart);
                    this.richTextBox.SelectionLength = RememberedFindTextBox.Length;
                }
                catch
                {
                    MessageBox.Show("Не найдено совпадений");
                }
            else if (sender is Button == false)
                FindToolStripMenuItem_Click(sender, e);
        }

        ReplaceForm Replacer;
        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replacer = new ReplaceForm();
            Replacer.Show();
            Replacer.ReplaceButton.Click += ReplaceButton_Click;
            Replacer.ReplaceAllButton.Click += ReplaceAllButton_Click;
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            while (true)
                try
                {
                    this.richTextBox.SelectionStart = this.richTextBox.Text.IndexOf(Replacer.WhatTextBox.Text);
                    this.richTextBox.SelectionLength = Replacer.WhatTextBox.Text.Length;
                    this.richTextBox.SelectedText = Replacer.WithTextBox.Text;
                }
                catch
                {
                    break;
                }
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.richTextBox.SelectionStart = this.richTextBox.Text.IndexOf(Replacer.WhatTextBox.Text);
                this.richTextBox.SelectionLength = Replacer.WhatTextBox.Text.Length;
                this.richTextBox.SelectedText = Replacer.WithTextBox.Text;
            }
            catch
            {
                MessageBox.Show("Не найдено совпадений");
            }
        }

        private void richTextBox_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.richTextBox.Size = this.ClientSize;
        }
    }
}
