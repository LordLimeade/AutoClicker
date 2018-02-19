using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            int code = 0;

            if (UntilStoppedRadioBtn.Checked)
            {
                code = 0;
            }
            else if (WhilePressedRadioBtn.Checked)
            {
                code = 1;
            }
            else if (SetAmountRadioBtn.Checked)
            {
                code = 2;
            }

            ClickerParams clicker = new ClickerParams();
            clicker.ShowDialog();
        }
    }
}
