using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_RenPy_Decompiler
{
    public partial class SCRIPTDECOMPILER : UserControl
    {

        private string pathtofolder;

        private bool ischeked = false;

        private string pathtofile;

        public SCRIPTDECOMPILER()
        {
            InitializeComponent();
        }

        private void CHS_FILE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "RPA files (*.rpa)|*.rpa"; // Фильтр для выбора файлов формата .rpa

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFile = dialog.FileName;
                    pathtofile = selectedFile;
                    TXT_FILE.Text = pathtofile;
                }
            }
        }

        private void CHS_OUT_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    pathtofolder = selectedPath;
                    TXT_OUTFOLDER.Text = pathtofolder;
                }
            }
        }

        private void DEC_Click(object sender, EventArgs e)
        {
            if (ischeked == false) { ischeked = true; MessageBox.Show("Make Sure You Install unrpa from Lattyware GitHub! ( Click at 'About' )", "INFO!");  }

            if (Directory.Exists(pathtofolder) & File.Exists(pathtofile) & ischeked)
            {
                Process.Start("cmd.exe", $"/C py -3 -m unrpa -mp {pathtofolder} {pathtofile}");
                if ( panel4.Visible == false )
                { panel4.Visible = true; }
                log.Text = $"File: |{pathtofile}| is succeful decompiled!";
            }
            else
            {
                if (!Directory.Exists(pathtofolder) & !File.Exists(pathtofile))
                { MessageBox.Show("Please Choose The Output Directory And The Rpa Archive!", "ERROR!"); }
                else { 
                if (!Directory.Exists(pathtofolder))
                { MessageBox.Show("Please Choose The Output Directory!","ERROR!"); }
                if (!File.Exists(pathtofile))
                { MessageBox.Show("Please Choose The Rpa Archive!","ERROR!"); }
                }
            }

        }

        private void OPN_OUT_DIR_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pathtofolder)) { 
            Process.Start(pathtofolder);
            }
        }
    }
}
