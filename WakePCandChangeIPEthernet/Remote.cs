using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WakePCandChangeIPEthernet
{
    internal class Remote
    {
        public bool IsMachineOnline(string hostIP)
        {
            bool status = false;

            try
            {
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(hostIP);

                if (pingReply.Status == IPStatus.Success)
                {
                    status = true;
                }
            }
            catch (Exception)
            {
                // Exception
            }
            
            return status;
        }
    }
}
