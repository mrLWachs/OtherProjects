using ComputerScience40S.computerscience20s;
using ComputerScience40S.computerscience30s;
using ComputerScience40S.computerscience40s.main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience40S
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cs20SButton_Click(object sender, EventArgs e)
        {
            new ComputerScience20S().Show();
        }

        private void cs30SButton_Click(object sender, EventArgs e)
        {
            new ComputerScience30S().Show();
        }

        private void cs40SButton_Click(object sender, EventArgs e)
        {
            new computerscience40s.main.ComputerScience40S().Show();
        }

        private void cs42SIBButton_Click(object sender, EventArgs e)
        {

        }
    }
}
