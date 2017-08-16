using AdapterPatternApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Classes
{
    class Mp4Player : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("(Mp4Player class)play MP4");
        }

        public void playVlc(string fileName)
        {
            //do nothing
        }
    }
}
