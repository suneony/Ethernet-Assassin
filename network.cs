using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disable_Internet_Application
{
    class network
    {

        public void ToggleInternet(bool enabled, string networkName)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string state = (enabled) ? "enabled" : "disabled";
            startInfo.Arguments = string.Format("/C netsh interface set interface {0} {1}", networkName, state);
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
