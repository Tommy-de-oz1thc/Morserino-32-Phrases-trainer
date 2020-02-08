

namespace Morserino_32
{


    using System.Collections.Generic;
    using Microsoft.Win32;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;
    using System.IO.Ports;
    using System;
    using System.IO;
    using Morserino32_CW_Phrases_trainer;

    public partial class Ports
    {
        private const uint GENERIC_ALL = 0x10000000;
        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private const uint GENERIC_EXECUTE = 0x20000000;
        private const int OPEN_EXISTING = 3;
        public const int INVALID_HANDLE_VALUE = -1;
        private static List<string> avable_Ports = new List<string>();
        private static SerialPort comPort;

        public  List<string> PortControl()
        {
            for (int i = 1; i <= 32; i++)
            {
                if (PortExists(i))
                {
                    avable_Ports.Add("Com" + i);
                }
            }

            return avable_Ports;
        }

        private  bool PortExists(int number)
        {
            SafeFileHandle h = CreateFile(@"\\.\COM" + number.ToString(), GENERIC_READ + GENERIC_WRITE,
                      0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);


            bool portExists = !h.IsInvalid;

            if (portExists)
                h.Close();

            return portExists;
        }
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern SafeFileHandle CreateFile(string lpFileName, System.UInt32 dwDesiredAccess,
       System.UInt32 dwShareMode, IntPtr pSecurityAttributes, System.UInt32 dwCreationDisposition,
       System.UInt32 dwFlagsAndAttributes, IntPtr hTemplateFile);


        public  SerialPort Get_Ports
        {
            get { return comPort; }

        }


        private void CheckPorts()
        {

            avable_Ports.Clear();
            avable_Ports = PortControl();

        }

        public SerialPort Connect(string comPort_S)
        {

            try
            {
                comPort = new SerialPort(comPort_S,
      115200, Parity.None, 8, StopBits.One);
                comPort.Open();

                
            }
            catch { }
            return comPort;
        }

        public void Close()
        {
            comPort.Close();
        }
    }
}

    
