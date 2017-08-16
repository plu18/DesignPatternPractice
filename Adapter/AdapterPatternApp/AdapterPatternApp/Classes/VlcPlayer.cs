using AdapterPatternApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Classes
{
    class VlcPlayer : AdvancedMediaPlayer
    {
        public void playVlc(string fileName)
        {
            Console.WriteLine("(VlcPlayer class)play VLC");
        }

        public void playMp4(string fileName)
        {
            //do nothing
        }
    }
}
