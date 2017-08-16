using AdapterPatternApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Classes
{
    public class MediaPlayerAdapter : MediaPlayer
    {
        AdvancedMediaPlayer _advancedMediaPlayer;

        public MediaPlayerAdapter(String audioType)
        {
            if (audioType.Equals("VLC", StringComparison.CurrentCultureIgnoreCase))
                _advancedMediaPlayer = new VlcPlayer();
            else if (audioType.Equals("mp4", StringComparison.CurrentCultureIgnoreCase))
                _advancedMediaPlayer = new Mp4Player();
            
        }


        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("VLC", StringComparison.CurrentCultureIgnoreCase))
                _advancedMediaPlayer.playVlc(fileName);
            else if (audioType.Equals("mp4", StringComparison.CurrentCultureIgnoreCase))
                _advancedMediaPlayer.playMp4(fileName);

        }


    }
}
