using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Interfaces
{
    interface AdvancedMediaPlayer
    {
        void playVlc(String fileName);
        void playMp4(String fileName);
    }
}
