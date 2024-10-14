using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_1
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int Hours, int minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = minutes;
            this.Seconds = Seconds;

        }
        public Duration(int Seconds)
        {
            this.Hours = Seconds / 3600;
            this.Minutes = (Seconds % 3600) / 60;
            this.Seconds = Seconds % 60;
        }
        public string getstring()
        {
            if (Hours > 0)
            {
                return $"Hours= {Hours} - minutes = {Minutes} - seconds= {Seconds}";
            }

            else
            {
                return $"minutes= {Minutes} - seconds = {Seconds}";
            }


        }
    }
}
