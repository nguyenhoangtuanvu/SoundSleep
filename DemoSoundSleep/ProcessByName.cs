using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSoundSleep
{
    class ProcessByName
    {
        void MyProcess()
        {
            System.Diagnostics.Process CurrentProcess = Process.GetCurrentProcess();
            Process[] browser = Process.GetProcessesByName("browser");
            Process[] chrome = Process.GetProcessesByName("chrome");
            Process[] wps = Process.GetProcessesByName("wps");
            /*Process[] browser = Process.GetProcessesByName("browser");
            Process[] browser = Process.GetProcessesByName("browser");
            Process[] browser = Process.GetProcessesByName("browser");*/
        }
    }
}
