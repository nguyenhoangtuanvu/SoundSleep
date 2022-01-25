using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSoundSleep
{
    public partial class FormMain : Form
    {
        public string profile;
        public string stthour, sttminute;
        public string endhour, endminute;
        public FormMain()
        {
            InitializeComponent();

        }
        List<ListBreak> listBreaks = new List<ListBreak>();

        /// <summary>
        /// receive data from add form
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="stth"></param>
        /// <param name="sttm"></param>
        /// <param name="endh"></param>
        /// <param name="endm"></param>
        public void GETVALUE(string pro, string stth, string sttm, string endh, string endm)
        {
            profile = pro;
            stthour = stth;
            sttminute = sttm;
            endhour = endh;
            endminute = endm;           

            ListBreak breaks = new ListBreak(profile, stthour, sttminute, endhour, endminute);
            listBreaks.Add(breaks);
            l.Items.Add(breaks.profile + "     "
                + breaks.stthour +":"
                + breaks.sttminute +" - "
                + breaks.endhour +":"
                + breaks.endminute);
        }
        /// <summary>
        /// receive data from edit form 
        /// </summary>
        /// <param name="pro"></param>
        /// <param name="stth"></param>
        /// <param name="sttm"></param>
        /// <param name="endh"></param>
        /// <param name="endm"></param>
        public void GETEDITDATA(string pro, string stth, string sttm, string endh, string endm)
        {
            profile = pro;
            stthour = stth;
            sttminute = sttm;
            endhour = endh;
            endminute = endm;

            ListBreak neww = new ListBreak(profile, stthour, sttminute, endhour, endminute);
            int location = l.SelectedIndex;
            if(pro == "cancel")
            {
                l.Items.RemoveAt(location);
                listBreaks.RemoveAt(location);
            }
            else 
            {
                l.Items.RemoveAt(location);
                l.Items.Insert(location, neww.profile);

                listBreaks.RemoveAt(location);
                listBreaks.Insert(location, neww);
            }
            
        }

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int location = l.SelectedIndex;
                ListBreak breaks = listBreaks.ElementAt(location);
                frmdetail frdt = new frmdetail(breaks.profile, breaks.stthour, breaks.sttminute, breaks.endhour, breaks.endminute);
                frdt.editeddata = new frmdetail.EDITDATA(GETEDITDATA);
                frdt.ShowDialog();
            }
            catch { }         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmadd frmadd = new frmadd();
            frmadd.Addbreak = new frmadd.SENDDATA(GETVALUE);
            frmadd.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //wanning();
            breaks();
            //System.Diagnostics.Process.Start("shutdown", "-s -t" + 10);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ứng dụng là sản phẩn của dự án Sound Sleep, tác giả là sinh viên nguyễn hoàng tuấn vũ");
        }

        /*void wanning()
{
   DateTime curtime = DateTime.Now;

   DateTime timewanning = curtime.AddMinutes(-5);
   foreach (ListBreak i in listBreaks)
   {

       if (i.stthour == curtime.Hour.ToString() && i.sttminute == timewanning.ToString())
       {
           MessageBox.Show("time to go to bed");
       }
   }
}*/
        void breaks()
        {
            DateTime curtime = DateTime.Now;
            foreach (ListBreak i in listBreaks)
            {
                if (i.stthour == curtime.Hour.ToString() && i.sttminute == curtime.Minute.ToString())
                {
                    SoundSleep ss = new SoundSleep(i.endhour, i.endminute);
                    ss.ShowDialog();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
