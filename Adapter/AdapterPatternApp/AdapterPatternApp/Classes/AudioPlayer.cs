using AdapterPatternApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Classes
{
    class AudioPlayer : MediaPlayer
    {
        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("mp4", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("(AudioPlayer Class) play mp4");
            }
            else if (audioType.Equals("vlc", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("(AudioPlayer Class) play VLC");
            }
            else
            {
                Console.WriteLine("System not support this type of audio");
            }
        }
    }
}
