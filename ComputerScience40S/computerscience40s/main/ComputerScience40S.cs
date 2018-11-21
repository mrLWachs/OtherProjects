using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// the large in class example we continue to work
/// on in each unit adding example code on the new concepts of each unit
/// along with any in class requests for code examples that might come up
/// </summary>
namespace ComputerScience40S.computerscience40s.main
{
    public partial class ComputerScience40S : Form
    {
        public ComputerScience40S()
        {
            InitializeComponent();
        }

        private void ComputerScience40S_Load(object sender, EventArgs e)
        {
            Tester.outputList = outputList;
            Tester.print("\nStarting CS40S Examples...\n");
            Tester.Start();
            Tester.print("\nCompleted CS40S Examples!\n");
            outputList.SelectedIndex = outputList.Items.Count - 1;
        }
    }
}
