using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Morserino_32
{
    public partial class Morserino
    {
        private static Read_from_Paddle R_f_Pad = new Read_from_Paddle();
        private static SerialPort comPort;
        public Morserino()
        { }

        public char Read_Char_from_M32(SerialPort comPort)
        {
            char c;
            c = R_f_Pad.Read_Char_from_M32(comPort);
           
            return c;
        }

        public string Read_Word_from_M32(SerialPort comPort)
        {
            string w;
            w = R_f_Pad.Read_from_Word(comPort);
            return w;
        }

        public List<string> Read_from_Phrases_M32(SerialPort comPort)
        {
            List<string> p = new List<string>();
            p = R_f_Pad.Read_from_Phrases(comPort);
            return p;
        }
    }
}
