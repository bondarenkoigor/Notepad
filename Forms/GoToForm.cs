using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class GoToForm : Form
    {
        public GoToForm()
        {
            InitializeComponent();
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReturnValue = int.Parse(this.StringNumTextBox.Text);
            }
            catch { }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
