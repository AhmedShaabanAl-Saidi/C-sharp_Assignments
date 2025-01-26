using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Duration
    {
        // 1 - Define Class 
        public int Hours;
        public int Minutes;
        public int Seconds;

        // 2 - Override All System.Object Members
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

        // 3 - Define All Required Constructors
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

        // 4 - Implement All required Operators overloading
        // D3=D1+D2
        public static Duration operator +(Duration d1,Duration d2)
        {
            return new Duration((d1?.Hours ?? 0) + (d2?.Hours ?? 0), (d1?.Minutes ?? 0) + (d2?.Minutes ?? 0), (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0));
        }

        // D3=D1+ 7800 , D3=D3+666
        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration((d1?.Hours ?? 0) + (seconds / 3600), (d1?.Minutes ?? 0) + ((seconds % 3600) / 60), (d1?.Seconds ?? 0) + ((seconds % 3600) % 60));
        }

        // D3= ++D1 (Increase One Minute)
        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes + 1, duration.Seconds);
        }

        // D3= --D2 (Decrease One Minute)
        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.Hours, duration.Minutes - 1, duration.Seconds);
        }

        // D1=D1-D2
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration((d1?.Hours ?? 0) - (d2?.Hours ?? 0), (d1?.Minutes ?? 0) - (d2?.Minutes ?? 0), (d1?.Seconds ?? 0) - (d2?.Seconds ?? 0));
        }

        // If (D1>D2)
        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1?.Hours ?? 0) > (d2?.Hours ?? 0) && (d1?.Minutes ?? 0) > (d2?.Minutes ?? 0) && (d1?.Seconds ?? 0) > (d2?.Seconds ?? 0);
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1?.Hours ?? 0) < (d2?.Hours ?? 0) && (d1?.Minutes ?? 0) < (d2?.Minutes ?? 0) && (d1?.Seconds ?? 0) < (d2?.Seconds ?? 0);
        }

        // If (D1<=D2)
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1?.Hours ?? 0) >= (d2?.Hours ?? 0) && (d1?.Minutes ?? 0) >= (d2?.Minutes ?? 0) && (d1?.Seconds ?? 0) >= (d2?.Seconds ?? 0);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1?.Hours ?? 0) <= (d2?.Hours ?? 0) && (d1?.Minutes ?? 0) <= (d2?.Minutes ?? 0) && (d1?.Seconds ?? 0) <= (d2?.Seconds ?? 0);
        }

        // If (D1)
        public static bool operator true(Duration duration)
        {
            return (duration?.Hours ?? 0) > 0 || (duration?.Minutes ?? 0) > 0 || (duration?.Seconds ?? 0) > 0;
        }

        public static bool operator false(Duration duration)
        {
            return (duration?.Hours ?? 0) <= 0 && (duration?.Minutes ?? 0) <= 0 && (duration?.Seconds ?? 0) <= 0;
        }

        // DateTime Obj = (DateTime) D1
        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(1, 1, 1, duration.Hours, duration.Minutes, duration.Seconds);
        }

    }
}
