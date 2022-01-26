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

namespace RiftNite_Launcher
{
    public partial class Form2 : Form
    {
        private string filePath;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (File.Exists(@"Files\Old\run.bat"))
            {
                Directory.SetCurrentDirectory(@"Files\Old");
                Process.Start("run.bat");
            }
            else
            {
                MessageBox.Show("There was an error starting Old RiftNite. Try restarting launcher", "RiftNite │ dsc.gg/riftnite");
            }
            MessageBox.Show("Dont close console until you finish using RiftNite.", "RiftNite │ dsc.gg/riftnite");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TURN OFF YOUR WIFI UNTIL YOU LAUNCH GAME WITH RIFTNITE \n WHEN YOU TURN OFF YOUR WIFI PRESS OK", "RiftNite │ dsc.gg/riftnite");
            MessageBox.Show("Are you sure you turned off wifi? \n ALSO YOU CAN TURN ON WIFI WHEN FORTNITE ALREADY STARTED", "RiftNite │ dsc.gg/riftnite");

            if (File.Exists(@"Files\Old\Rift.exe"))
            {
                Directory.SetCurrentDirectory(@"Files\Old");
                Process.Start("Rift.exe");
            }
            else
            {
                MessageBox.Show("There was an error starting RiftNite6.5. Try restarting launcher", "RiftNite │ dsc.gg/riftnite");
            }
            MessageBox.Show("If new RiftNite is not working try to use old RiftNite", "RiftNite │ dsc.gg/riftnite");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Support of this event will be added soon! Join dsc.gg/riftnite to download it when this releases", "RiftNite │ dsc.gg/riftnite");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Files\Carbon\Carbon.bat"))
            {
                Directory.SetCurrentDirectory(@"Files\Carbon");
                Process.Start("Carbon.bat");
            }
            else
            {
                MessageBox.Show("There was an error starting Carbon. Try restarting launcher", "RiftNite │ dsc.gg/riftnite");
            }
            MessageBox.Show("Some controls of fixed Carbon: \n Go ingame - F3 \n After you join game press F2 and DONT OPEN GLIDER OR YOUR GAME WILL CRASH \n F6 to fly \n F5 to start menu where you can put weapons, change pov and other cool things \n If its not working write it to our server dsc.gg/riftnite \n Have fun using Carbon with skins!", "RiftNite │ dsc.gg/riftnite");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well just restart launcher and try pressing button again. If it doesnt work then just open Files folder (its hidden) and open launcher u want \n Also I will make an update very soon fixing this problem!", "RiftNite │ dsc.gg/riftnite");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Files\Launcher\Rift.exe"))
            {
                Directory.SetCurrentDirectory(@"Files\Launcher");
                Process.Start(@"Rift.exe");
            }
            else
            {
                MessageBox.Show("There was an error starting Rift. Try restarting launcher", "RiftNite │ dsc.gg/riftnite");
            }
            MessageBox.Show("If new RiftNite is not working try to use old RiftNite", "RiftNite │ dsc.gg/riftnite");
        }
    }
}
