using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormWin : Form
    {
        public FormWin()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            lbplayerName.Text = Const.type;
            string text = "";
            text += Const.time.Hours.ToString("00") + ":" +
            Const.time.Minutes.ToString("00") + ":" +
            Const.time.Seconds.ToString("00");
            lbTimePoint.Text = text;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?",
                "Quit",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
        }

        private void FormWin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
            this.Focus();
        }
    }
}
