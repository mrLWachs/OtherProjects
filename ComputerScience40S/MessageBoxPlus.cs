using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience40S.computerscience30s
{
    public partial class frmMessageBoxPlus : Form
    {
        public frmMessageBoxPlus(string text, string title, Form parent,
            string fontName)
        {
            InitializeComponent();
            this.rtbText.Font = new Font(fontName, 12, FontStyle.Regular);
            this.rtbText.Text = text;
            Text = title;
            this.ShowDialog(parent);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
