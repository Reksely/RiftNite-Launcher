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
using DiscordRpcDemo;

namespace RiftNite_Launcher
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("897887053583376384", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("897887053583376384", ref this.handlers, true, null);
            this.presence.details = "RiftNite - dsc.gg/riftnite";
            this.presence.state = "RiftNite - Adds all skins to Rift";
            this.presence.largeImageKey = "fortnite-junk-rift";
            this.presence.smallImageKey = "fortnite-junk-rift";
            this.presence.largeImageText = "dsc.gg/riftnite";
            this.presence.smallImageText = "dsc.gg/riftnite";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private static void NewMethod()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Files\Old\RiftInstaller.exe"))
            {
                Directory.SetCurrentDirectory(@"Files\Old");
                Process.Start("RiftInstaller.exe");
            }
            else
            {
                MessageBox.Show("There was an error starting RiftInstaller. Try restarting launcher", "RiftNite │ dsc.gg/riftnite");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dsc.gg/riftnite");
        }
    }
}
