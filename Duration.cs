using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = (seconds % 3600) % 60;
        }

        public override string ToString()
        {
            if (Hours == 0) 
                return $"{Minutes} Minutes, {Seconds} Seconds";
            else 
                return $"{Hours} Hours, {Minutes} Minutes, {Seconds} Seconds";
        }

        public override bool Equals(object? obj)
        {
            Duration duration = (Duration)obj;

            return (Hours == duration.Hours) && (Minutes == duration.Minutes) && (Seconds == duration.Seconds);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
