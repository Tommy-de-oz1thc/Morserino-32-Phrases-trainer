using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MorseGen
{
    public class MorseGenerator
    {
        private int pitch;
        private int wpm;
        private int volume;
        private WaveOut wav = null;

        public int Picth {
            get { return pitch; }
            set
            {
                if (value < 100 || value > 10000)
                    throw new ArgumentOutOfRangeException();
                pitch = value;
            }
        }

        public int WPM
        {
            get { return wpm; }
            set { 
                if (value <= 0) 
                    throw new ArgumentOutOfRangeException(); 
                wpm = value; 
            }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException("Volume", "Volume must be between 0 and 100");
                volume = value;
            }
        }

        public MorseGenerator()
        {
            pitch = 700;
            wpm = 15;
            volume = 20;
        }

        public void PlayMorse(string Text)
        {
            if (wav != null)
            {
                wav.Stop();
                wav.Dispose();
            }

            wav = new WaveOut();
            MorseProvider mp = new MorseProvider();
            mp.SetWaveFormat(16000, 1);
            //mp.WaveFormat = new WaveFormat(16000, 1);
            mp.Initialize(pitch, volume, wpm, Text);
            wav.Init(mp);
            wav.Play();
            
        }
        public void StopMorse()
        {
            wav.Stop();
            wav.Dispose();
        }
    }
}
