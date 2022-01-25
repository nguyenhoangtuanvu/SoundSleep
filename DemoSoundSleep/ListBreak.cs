using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSoundSleep
{
    class ListBreak
    {
        public string profile;
        public string stthour, sttminute;
        public string endhour, endminute;

        public ListBreak(string profile, string stthour, string sttminute, string endhour, string endminute)
        {
            this.profile = profile;
            this.stthour = stthour;
            this.sttminute = sttminute;
            this.endhour = endhour;
            this.endminute = endminute;
        }
        //public string day;
    }
/*    class ListMusic
    {
        string  Sname;

        public ListMusic( string n)
        {
            this.Sname = n;
        }
    }*/

}

