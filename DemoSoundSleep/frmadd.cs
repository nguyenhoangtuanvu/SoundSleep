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
    public partial class frmadd : Form
    {
        public delegate void SENDDATA(string profile, string stthour, string sttminute, string endhour, string endminute);
        public SENDDATA Addbreak;
        public frmadd()
        {
            InitializeComponent();
        }
        private void frmadd_Load(object sender, EventArgs e)
        {          
            for (int i = 0; i <= 24; i++)
            {
                cbb1.Items.Add(i);
            }
            for (int j = 0; j <= 59; j++ /*= j + 10*/)
            {
                cbb2.Items.Add(j);
            }
            for (int a = 0; a <= 24; a++)
            {
                cbb3.Items.Add(a);
            }
            for (int b = 0; b <= 59; b++ /*= b + 10*/)
            {
                cbb4.Items.Add(b);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
/*            string profile = txtprofile.Text;
            string stthour = cbb1.SelectedItem.ToString();
            string sttminute = cbb2.SelectedItem.ToString();
            string endhour = cbb3.SelectedItem.ToString();
            string endminute = cbb4.SelectedItem.ToString();*/
            if(txtprofile.Text.Length>0)
            {
                if (cbb1.SelectedItem.ToString() != null && cbb2 != null && cbb3 != null && cbb4 != null && txtprofile != null)
                {
                    Addbreak(txtprofile.Text,
                            cbb1.SelectedItem.ToString(),
                            cbb2.SelectedItem.ToString(),
                            cbb3.SelectedItem.ToString(),
                            cbb4.SelectedItem.ToString());
                }    
                else
                {
                    MessageBox.Show("please input full  time blank!");
                }
            }
            else
            {
                MessageBox.Show("please input full information!");
            }

            this.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
