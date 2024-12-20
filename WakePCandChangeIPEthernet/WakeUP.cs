﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Management;

namespace WakePCandChangeIPEthernet
{
    internal class WakeUP
    {
        public void wakeProc() {

            var macAddress = "00-15-58-E3-EF-16";                      // Our device MAC address
            macAddress = Regex.Replace(macAddress, "[-|:]", "");       // Remove any semicolons or minus characters present in our MAC address

            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
            {
                EnableBroadcast = true
            };

            int payloadIndex = 0;

            /* The magic packet is a broadcast frame containing anywhere within its payload 6 bytes of all 255 (FF FF FF FF FF FF in hexadecimal), followed by sixteen repetitions of the target computer's 48-bit MAC address, for a total of 102 bytes. */
            byte[] payload = new byte[1024];    // Our packet that we will be broadcasting

            // Add 6 bytes with value 255 (FF) in our payload
            for (int i = 0; i < 6; i++)
            {
                payload[payloadIndex] = 255;
                payloadIndex++;
            }

            // Repeat the device MAC address sixteen times
            for (int j = 0; j < 16; j++)
            {
                for (int k = 0; k < macAddress.Length; k += 2)
                {
                    var s = macAddress.Substring(k, 2);
                    payload[payloadIndex] = byte.Parse(s, NumberStyles.HexNumber);
                    payloadIndex++;
                }
            }

            sock.SendTo(payload, new IPEndPoint(IPAddress.Parse("192.168.0.2"), 0));  // Broadcast our packet
            sock.Close(10000);
        }
    }
}
