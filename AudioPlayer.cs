using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic6
{
    /// <summary>
    /// Задание №1. Свойства 
    /// Класс аудиоплеер
    /// </summary>
    class AudioPlayer
    {
        const int MAX_VOL = 100;
        const int MIN_VOL = 0;

        int vol;
        int lastVol = 0;
        public int Vol
        {
            get
            {
                return vol;
            }
            set
            {
                if (value < MIN_VOL)
                {
                    vol = MIN_VOL;
                }
                else if (value > MAX_VOL)
                {
                    vol = MAX_VOL;
                }
                else
                {
                    vol = value;
                }
            }
        }

        //Mute volume
        public void mute()
        {
            if (lastVol == 0)
            {
                lastVol = Vol; Vol = 0;
            }
            else
            {
                vol = lastVol; lastVol = 0; 
            }
             
        }

    }
}
