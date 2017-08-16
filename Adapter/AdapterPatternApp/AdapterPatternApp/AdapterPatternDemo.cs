using AdapterPatternApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp
{
    class AdapterPatternDemo
    {
        static void Main(string[] args)
        {
            AudioPlayer _audioPlayer = new AudioPlayer();

            _audioPlayer.play("mp4", "shabi111.mp4");
            _audioPlayer.play("VLC", "shabi222.vlc");
            _audioPlayer.play("MP4", "shabi333.mp4");
            _audioPlayer.play("mp3", "shabi444.mp3");

            Console.ReadKey();
        }
    }
}
