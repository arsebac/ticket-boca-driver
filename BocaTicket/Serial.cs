using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocaTicket
{
    
    using System;
    using System.Drawing;
    using System.IO.Ports;
    using System.Threading;
    using System.Windows.Forms;

    namespace Serial_Port
    {
        public class PortAccess
        {
            public static Parity parity = Parity.None;
            public static StopBits stopbits = StopBits.One;
            public static int databits = 8;
            public static int baud = 9600;
            public static SerialPort Boca_Serial;
            public static PortAccess boca_com;

            public static string OPENED = "opened";

            public PortAccess()
            {
                PortAccess.boca_com = this;
            }

            public static string Open_Serial(string portname)
            {
                string flag = "Pas de connection";
                if (PortAccess.Boca_Serial == null)
                    PortAccess.Boca_Serial = new SerialPort();
                if (PortAccess.Boca_Serial.IsOpen)
                    PortAccess.Boca_Serial.Close();
                try
                {
                    PortAccess.Boca_Serial.BaudRate = PortAccess.baud;
                    PortAccess.Boca_Serial.Parity = PortAccess.parity;
                    PortAccess.Boca_Serial.StopBits = PortAccess.stopbits;
                    PortAccess.Boca_Serial.DataBits = PortAccess.databits;
                    PortAccess.Boca_Serial.PortName = portname;
                    PortAccess.Boca_Serial.Open();
                }
                catch(Exception e)
                {
                    flag = e.Message;
                }
                if (PortAccess.Boca_Serial.IsOpen)
                {
                    flag = OPENED;
                }
                else
                {
                    Console.WriteLine("Failed to open serial port " + portname);
                }
                return flag;
            }
            public static void write_serial(string command)
            {
                if (PortAccess.Boca_Serial == null || !PortAccess.Boca_Serial.IsOpen)
                    return;
                PortAccess.Boca_Serial.Write(command);
            }   
        }
    }

}
