using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace Morserino_32
{
    public class Read_from_Paddle : Morserino
    {
        private static SerialPort comPort;
        private bool praticePhrases = false;

        public char Read_Char_from_M32(SerialPort comPort)
        {
            
                char c ='#';
            try
            {
                c = Convert.ToChar(comPort.ReadChar());
            }
            catch { }

                return c;
           
        }

        public string Read_from_Word(SerialPort comPort)
        {
            string w = "";
            char c = '#';
            while (true)
            {
                c = Read_Char_from_M32(comPort);
                w += c.ToString();
                if ((c== '*') && (!praticePhrases))
                {
                    return "*";
                }
                if (c == ' ')
                { break; }
            }
            return w;
        }

        public List<string> Read_from_Phrases(SerialPort comPort)
        {
            praticePhrases = true;
            string w = "";
            List<string> p = new List<string>();
            while (true)
            {
                
                w = Read_from_Word(comPort).Trim();
                p.Add(w);
                if(w.Contains("*"))
                {
                    try
                    {
                        p.Remove(p.Last());
                        p.Remove(p.Last());
                    }
                    catch { }
                }
                if (w.Contains("="))
                    { break; }
            }
            praticePhrases = false;
            return p;
        }

       
    }
}
