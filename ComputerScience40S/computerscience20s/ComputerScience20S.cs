using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience40S.computerscience20s
{
    public partial class ComputerScience20S : Form
    {
        public ComputerScience20S()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rdbIntroToProgramming.Checked)            new frmIntroductionToProgrammingExample().Show();
            else if (rdbVariables1.Checked)               new frmVariablesExample1().Show();
            else if (rdbVariables2.Checked)               new frmVariablesExample2().Show();
            else if (rdbConditionals1.Checked)            new frmConditionalStatementsExample1().Show();
            else if (rdbConditionals2.Checked)            new frmConditionalStatementsExample2().Show();
            else if (rdbLooping1.Checked)                 new frmLoopingExample1().Show();
            else if (rdbLooping2.Checked)                 new frmLoopingExample2().Show();
            else if (rdbProgrammingExtras1.Checked)       new frmProgrammingExtras1Form1().Show();
            else if (rdbProgrammingExtras2.Checked)       new frmProgrammingExtras2().Show();
            else if (rdbProgrammingExtras3.Checked)       new frmProgrammingExtras3().Show();
            else if (rdbProgrammingExtras4.Checked)       new frmProgrammingExtras4().Show();
            else if (rdbAdvancedProgrammingExtra.Checked) new frmAdvancedProgrammingExtra().Show();
            else
            {
                MessageBox.Show(
                    this,
                    "Please make a selection!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

    }
}
