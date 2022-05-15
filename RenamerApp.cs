using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (txtDiretorio.Text.Trim().Length > 0)
            {
                string[] filePaths = Directory.GetFiles(@txtDiretorio.Text.Trim());
                if (filePaths.Length > 0)
                {
                    barraProgresso.Value = 0;
                    barraProgresso.Maximum = filePaths.Length;
                    if (chkToUpperCase.Checked)
                    {
                        for (int i = 0; i < barraProgresso.Maximum; i++)
                        {

                            File.Move(filePaths[i], filePaths[i].ToUpper());
                            barraProgresso.Value++;
                        }
                    }
                    else if (chkToLowerCase.Checked)
                    {
                        for (int i = 0; i < barraProgresso.Maximum; i++)
                        {

                            File.Move(filePaths[i], filePaths[i].ToLower());
                            barraProgresso.Value++;
                        }
                    }
                }
            }
        }

        private void RenamerApp_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                txtDiretorio.Text = "";
            }
        }
    }
}
