using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenamerApp
{
    public partial class RenamerApp : Form
    {
        public RenamerApp()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox sobre = new AboutBox();
            sobre.ShowDialog();
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            barraProgresso.Maximum = 1000;
            barraProgresso.Value = 0;
            for(int i = 0; i < barraProgresso.Maximum; i++)
            {
                barraProgresso.Value++;
            }
        }

        private void RenamerApp_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }
    }
}
