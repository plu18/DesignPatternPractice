﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Interfaces
{
    interface MediaPlayer
    {
        void play(String audioType, String fileName);
    }
}
