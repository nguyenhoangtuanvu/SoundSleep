using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace DemoSoundSleep
{
    public partial class SoundSleep : Form
    {
        public string endhour, endminute;
        public int CPA;
        public int CPB;
        FolderBrowserDialog fd;
        public SoundSleep(string endh, string endm)
        {
            InitializeComponent();
            this.endhour = endh;
            this.endminute = endm;
        }

        public void SoundSleep_Load(object sender, EventArgs e)
        {
            FileStream stream = File.OpenRead(path);
            StreamReader read = new StreamReader(stream);
            string line = "";
            ListSong.Items.Clear();
            WMPLib.IWMPPlaylist playlist = media.newPlaylist(path, string.Empty);
            while ((line = read.ReadLine()) != null)
            {
                WMPLib.IWMPMedia pMedia = media.newMedia(line);
                playlist.appendItem(pMedia);
                ListSong.Items.Add(line);
            }
            media.currentPlaylist = playlist;
            media.Ctlcontrols.play();
            media.settings.autoStart = true;

            Fullscreen(true);
            timer1.Start();
            timer2.Start();
            timer3.Start();
            DateTime curtime = DateTime.Now;
            int H = curtime.Hour;
            int M = curtime.Minute;
            int endhh = Convert.ToInt32(endhour);
            int endmm = Convert.ToInt32(endminute);
            int TimeEnd1;
            int TimeEnd2;
            if (endhh >= H)
            {
                TimeEnd1 = endhh - H;
                TimeEnd2 = endmm - M;
                lbh.Text = TimeEnd1.ToString();
                lbm.Text = TimeEnd2.ToString();
            }
            else if (endhh < H && endmm > M)
            {
                TimeEnd1 = (endhh + 24) - H;
                TimeEnd2 = endmm - M;
                lbh.Text = TimeEnd1.ToString();
                lbm.Text = TimeEnd2.ToString();
            }
            else if(endhh < H && endmm < M)
            {
                TimeEnd1 = (endhh + 23) - H;
                TimeEnd2 = (endmm + 60) - M;
                lbh.Text = TimeEnd1.ToString();
                lbm.Text = TimeEnd2.ToString();
            }

            // kill process da co
            System.Diagnostics.Process currentProcess = Process.GetCurrentProcess();
            Process[] chrome = Process.GetProcessesByName("chrome");
            Process[] browser = Process.GetProcessesByName("browser");
            Process[] wps = Process.GetProcessesByName("wps");
            Process[] msedge = Process.GetProcessesByName("msedge");
            Process[] ZaLo = Process.GetProcessesByName("ZaLo");
            Process[] EXCEL = Process.GetProcessesByName("EXCEL");
            Process[] POWERPNT = Process.GetProcessesByName("POWERPNT");
            Process[] WINWORD = Process.GetProcessesByName("WINWORD");
            Process[] VICTOREM908GamingMouse = Process.GetProcessesByName("VICTOR EM908 Gaming Mouse");
            Process[] TeamViewer = Process.GetProcessesByName("TeamViewer");
            
            foreach (Process proces in chrome)
            {
                proces.Kill();
            }
            foreach (Process proces in browser)
            {
                proces.Kill();
            }
            foreach (Process proces in wps)
            {
                proces.Kill();
            }
            foreach (Process proces in msedge)
            {
                proces.Kill();
            }
            foreach (Process proces in ZaLo)
            {
                proces.Kill();
            }
            foreach (Process proces in EXCEL)
            {
                proces.Kill();
            }
            foreach (Process proces in POWERPNT)
            {
                proces.Kill();
            }
            foreach (Process proces in WINWORD)
            {
                proces.Kill();
            }
            foreach (Process proces in VICTOREM908GamingMouse)
            {
                proces.Kill();
            }
            foreach (Process proces in TeamViewer)
            {
                proces.Kill();
            }
        }
        void reload()
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// When running the program, it will automatically switch to full screen mode
        /// </summary>
        /// <param name="fullscreen"></param>
        private void Fullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void openFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Mp3|*.mp3";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WMPLib.IWMPPlaylist playlist = media.newPlaylist("My PlayList", string.Empty);
                foreach (string file in open.FileNames)
                {
                    WMPLib.IWMPMedia pMedia = media.newMedia(file);
                    playlist.appendItem(pMedia);
                    ListSong.Items.Add(file);
                }
                media.currentPlaylist = playlist;
                media.Ctlcontrols.play();
                media.settings.autoStart = true;
                //media.settings.setMode("loop", true); // lap bai
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))// neu chua có file này thì tạo
            {
                File.Create(path);
            }
            FileStream stream = File.OpenWrite(path); // mở ham viết file docx
            StreamWriter write = new StreamWriter(stream); // tạo hàm viết 
            foreach (ListViewItem item in ListSong.Items)
            {
                write.WriteLine(item.Text);
            }
            write.Close();
            stream.Close();
            MessageBox.Show("success...");
        }
        public string path= @"C:\Users\DELL\Documents\MyPlayList.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream stream = File.OpenRead(path);
            StreamReader read = new StreamReader(stream);
            string line = "";
            ListSong.Items.Clear();
            WMPLib.IWMPPlaylist playlist = media.newPlaylist(path, string.Empty);
            while ((line = read.ReadLine()) != null)
            {
                WMPLib.IWMPMedia pMedia = media.newMedia(line);
                playlist.appendItem(pMedia);
                ListSong.Items.Add(line);

            }
            media.currentPlaylist = playlist;
            media.Ctlcontrols.play();
            media.settings.autoStart = true;
            //media.settings.setMode("loop", true);// lặp bài
        }
        private void lstnhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            media.URL = ListSong.FocusedItem.Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // run timing clock and stop timer2
            timer2.Stop();
            int a = Int32.Parse(lbs.Text);
            int b = Int32.Parse(lbm.Text);
            int c = Int32.Parse(lbh.Text);
            a--;
            if (a < 0)
            {
                a = 59;
                b--;
                if (b < 0)
                {
                    b = 59;
                    c--;
                }
            }

            if (a < 10)
            {
                lbs.Text = "0" + a;
            }
            else
                lbs.Text = a + "";
            if (b < 10)
            {
                lbm.Text = "0" + b;
            }
            else
                lbm.Text = b + "";
            if (c < 10)
            {
                lbh.Text = "0" + c;
            }
            else
                lbh.Text = c + "";

            if (a == 0 && b == 0 && c == 0)
            {
                timer1.Stop();
                timer3.Stop();
                this.Dispose();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //get process còn lại sau khi kill
            // kill process tiep tuc bat
            System.Diagnostics.Process newProcess = Process.GetCurrentProcess();
            Process[] process_before = Process.GetProcesses();
            CPB = process_before.Length;
        }

        private void timer3_Tick(object sender, EventArgs e)
        { // get process now
            // process after.
            Process[] process_after = Process.GetProcesses();
            CPA = process_after.Length;
            if (CPA - CPB >= 3)
            {
                reload();
                MessageBox.Show("You must not use the device now!");
            }
        }
    }
}


