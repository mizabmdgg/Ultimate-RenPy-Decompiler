using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_RenPy_Decompiler
{
    public partial class Form1 : Form
    {

        public bool IsUsingRPADECOMPILER = true;


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public Form1()
        {
            InitializeComponent();
            scriptdecompiler1.Show();
            rpadecompiler1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsUsingRPADECOMPILER = !IsUsingRPADECOMPILER;
            
            if (IsUsingRPADECOMPILER) 
            {
                scriptdecompiler1.Show();
                rpadecompiler1.Hide();
                button2.Text = "Rpa Decompiler";
            }
            else
            {
                scriptdecompiler1.Hide();
                rpadecompiler1.Show();
                button2.Text = "Script Decompiler";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           About settingsForm = new About();
           
           settingsForm.ShowDialog();
        }
    }
}
