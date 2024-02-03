using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
namespace TitanicDownloader
{
    public partial class Form1 : Form
    {
        List<Utils.Osudata> list = Utils.GetData();
        static bool HasInternetAccess()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com", 1000);

                return (reply != null && reply.Status == IPStatus.Success);
            }
            catch (PingException)
            {
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (HasInternetAccess())
            {

                foreach (var data in list)
                {
                    listBox1.Items.Add(data.build_name);
                }
            } else
            {
                MessageBox.Show("This app requires Internet Connection", "TitanicDownloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        string GetBuildName()
        {
            return listBox1.GetItemText(listBox1.SelectedItem);
        }
        string GetDesc1()
        {
            foreach (var data in list)
            {
                if (data.build_name == listBox1.GetItemText(listBox1.SelectedItem))
                    return data.description;

            }
            return "no such build";
        }
        string GetDesc2()
        {
            foreach (var data in list)
            {
                if (data.build_name == listBox1.GetItemText(listBox1.SelectedItem))
                    return data.known_bugs;

            }
            return "no such build";
        }
        string GetURLPath()
        {
            foreach (var data in list)
            {
                if (data.build_name == listBox1.GetItemText(listBox1.SelectedItem))
                {
                    foreach (var ss in data.screenshots)
                    {
                        return ss.src;
                    }
                }

            }
            return "no such build";
        }
        string ParseImg()
        {
            if (!Directory.Exists("./imgs"))
                Directory.CreateDirectory("./imgs");
            foreach (var data in list)
            {
                if (data.build_name == listBox1.GetItemText(listBox1.SelectedItem))
                {
                    foreach (var ss in data.screenshots)
                    {
                        return ss.src.Split('/')[3];
                    }
                    return null;
                }
                return null;

            }
            return null;
        }
        private void List_Test(object sender, EventArgs e)
        {
            build_name.Text = GetBuildName();
            desc1.Text = $"Description: {GetDesc1()}";
            desc2.Text = $"Known bugs: {GetDesc2()}";
            //webBrowser1.Url = new Uri("https://osu.lekuru.xyz" + GetURLPath());
            //new WebClient().DownloadFile("https://osu.lekuru.xyz" + GetURLPath(), "./imgs/" + ParseImg());
            pictureBox1.ImageLocation = "https://osu.lekuru.xyz" + GetURLPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var data in list)
            {
                if (data.build_name == listBox1.GetItemText(listBox1.SelectedItem))
                {
                    foreach (var download in data.downloads)
                    {
                        if (Directory.Exists($"./{data.build_name}"))
                        {
                            try
                            {
                                if (File.Exists($"./{data.build_name}/osu!test.exe"))
                                {
                                    Process.Start($"{Application.StartupPath}\\{data.build_name}\\osu!test.exe");
                                }
                                else
                                {
                                    Process.Start($"{Application.StartupPath}\\{data.build_name}\\osu!.exe");
                                }
                            } catch
                            {

                            }
                        } else {
                            if (!Directory.Exists("./temp"))
                                Directory.CreateDirectory("./temp");
                            new WebClient().DownloadFile(download, "./temp/tmp.zip");
                            var zip = ZipFile.Read("./temp/tmp.zip");

                            if (!Directory.Exists($"./{data.build_name}"))
                                Directory.CreateDirectory($"./{data.build_name}");
                            zip.ExtractAll($"./{data.build_name}");
                            DialogResult msgbox = MessageBox.Show("Client has been downloaded, do you wanna start it now?", "TitanicDownloader", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            switch (msgbox)
                            {
                                case DialogResult.Yes:
                                    {
                                        try
                                        {
                                            if (File.Exists($"./{build_name}/osu!test.exe"))
                                            {
                                                Process.Start($"{Application.StartupPath + data.build_name}/osu!test.exe");
                                            }
                                            else
                                            {
                                                Process.Start($"{Application.StartupPath + data.build_name}/osu!.exe");
                                            }


                                        }
                                        catch
                                        {

                                        }
                                        break;
                                    }
                                case DialogResult.No:
                                    {
                                        break;
                                    }
                            }
                        }
                        
                    }
                }

            }
        }
    }
}
