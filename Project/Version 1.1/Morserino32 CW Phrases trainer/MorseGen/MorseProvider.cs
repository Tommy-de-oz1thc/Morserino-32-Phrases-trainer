using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MorseGen
{
    class MorseProvider: WaveProvider32
    {
        private float[] wbuffer;
        private float dotms, dashms, space, samplems, volume;
        private int dotsamples, dashsamples, spacesamples, sinesamples, pitch, ipos = 0;
        private static int Farnsworth_Words = 0;
        private static int Farnsworth_Letters = 0;
        private static bool add_voice = false;
        Random rand = new Random();
        public MorseProvider()
        {
            wbuffer = new float[0];
        }


        public static int Set_Farnsworth_Words
        {
            set { Farnsworth_Words = value; }
        }

        public static int Set_Farnsworth_Letters
        {
            set { Farnsworth_Letters = value; }
        }

        public void Initialize(int Pitch, int Volume, int WPM, string Text)
        {
            List<float> buf = new List<float>();

            dotms = 1200.0f / WPM;
            dashms = 3 * dotms;
            space = 7 * dotms;
            samplems = 1000.0f / WaveFormat.SampleRate;
            dotsamples = Convert.ToInt32(dotms / samplems);
            dashsamples = Convert.ToInt32(dashms / samplems);
            spacesamples = Convert.ToInt32(space / samplems);
            sinesamples = Convert.ToInt32(WaveFormat.SampleRate / Pitch);
            pitch = Pitch;
            volume = Volume / 100.0f;

            Text = Text.ToUpper();
            bool bfirst = true;
            foreach (Char c in Text)
            {
                const Char var_strop = '\x0027';
                if (!bfirst && c != ' ') AddSpace(buf, dashsamples);
                bfirst = false;
                switch (c)
                {
                    case ' ':
                        for(int f=0;f< Farnsworth_Words;f++)
                        { AddSpace(buf, spacesamples); }
                        AddSpace(buf, spacesamples);
                        bfirst = true;
                        break;
                    case 'A': 
                        AddDot(buf); 
                        AddDash(buf);
                        break;
                    case 'B':
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case 'C':
                        AddDash(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case 'D':
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case 'E':
                        AddDot(buf);
                        break;
                    case 'F':
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case 'G':
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case 'H':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case 'I':
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case 'J':
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case 'K':
                        AddDash(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case 'L':
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case 'M':
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case 'N':
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case 'O':
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case 'P':
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case 'Q':
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case 'R':
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case 'S':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case 'T':
                        AddDash(buf);
                        break;
                    case 'U':
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case 'V':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case 'W':
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case 'X':
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case 'Y':
                        AddDash(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case 'Z':
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '/':
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;
                    case '?':
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '.':
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case ',':
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case '=':
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case '#':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '0':
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case '1':
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case '2':
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case '3':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        AddDash(buf);
                        break;
                    case '4':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDash(buf);
                        break;
                    case '5':
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '6':
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '7':
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '8':
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        AddDot(buf);
                        break;
                    case '9':
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDash(buf);
                        AddDot(buf);
                        break;

                }
                if(c!= ' ')
                {
                    for (int f = 0; f < Farnsworth_Letters; f++)
                    { AddSpace(buf, dotsamples); }
                }
                if (c == var_strop)
                {
                    AddDot(buf);
                    AddDash(buf);
                    AddDash(buf);
                    AddDash(buf);
                    AddDash(buf);
                    AddDot(buf);
                }
            }
            wbuffer = buf.ToArray();
        }

        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            int n = 0;

            for (int i = 0; i < sampleCount; i++)
            {
                if (i + ipos < wbuffer.Length)
                {
                    buffer[i + offset] = wbuffer[i + ipos];
                    n++;
                }
                else break;
            }
            ipos += n;
            return n;
        }

        private void AddDot(List<float> buf)
        {
            int samples = dotsamples / sinesamples;
            AddSine(buf, samples * sinesamples);
            AddSpace(buf, dotsamples);
           
        }

        private void AddDash(List<float> buf)
        {
            int samples = dashsamples / sinesamples;
            AddSine(buf, samples * sinesamples);
            AddSpace(buf, dotsamples);
           
        }

        private void AddSpace(List<float> buf, int samples)
        {
            for (int i = 0; i < samples; i++)
                buf.Add(0);
           
        }
       
        private void AddSine(List<float> buf, int samples)
        {
            int si = 0;
            float attack = 0.05f;
            for (int i = 0; i < samples; i++)
            { int voice = 1;
                if (add_voice)
                {
                    voice = rand.Next(10, 550);
                }
                buf.Add((float)(attack * volume * voice* Math.Sin((2 * Math.PI * si * pitch)  / WaveFormat.SampleRate)));
                si++;
                if (i > samples - 20 && attack > 0) attack -= 0.05f;
                else if (attack < 1) attack += 0.05f;
                if (si >= WaveFormat.SampleRate) si = 0;
            }
        }

        public static void Set_Voice(bool voice)
        {
            add_voice = voice;
        }
    }
}
