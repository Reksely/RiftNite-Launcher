using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace RiftNite_Launcher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Files\Old\face_injector_v2.exe"))
            {
                Directory.SetCurrentDirectory(@"Files\Old");
                Process.Start(@"face_injector_v2.exe");
            }
            else
            {
                MessageBox.Show("There was an error starting injector. Try restarting launcher", "RiftNite │ dsc.gg/riftnite");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void NewMethod(WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Directory.SetCurrentDirectory(@"Files\Carbon");
                Process.Start("run.bat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cdn.discordapp.com/attachments/889112399976747008/893158200419962890/Cranium_Zero_Crisis.dll");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basically launch s16 and then after blue screen appears click inject. Click ok to look how to inject (there is diffrent injector that we use rn)", "RiftNite │ dsc.gg/riftnite");
            System.Diagnostics.Process.Start("https://youtu.be/USeQCGqDYeM");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Close();
        }
    }
}
