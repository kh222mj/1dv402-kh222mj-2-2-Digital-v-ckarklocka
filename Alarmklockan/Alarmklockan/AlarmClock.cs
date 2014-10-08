using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmklockan
{
    public class AlarmClock
    {
        private int _alarmHour; 

        private int _alarmMinute;

        private int _hour;

        private int _minute;
        public int AlarmHour 
        {
            get { return _alarmHour; }
            set
            {
                if (value < 23 || value > 0)
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 59 || value > 0)
                {
                    throw new ArgumentException();
                }
                _alarmMinute = value;
            }
        }
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 23 || value > 0)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 59 || value > 0)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }
        public AlarmClock() 
        {
 
        }
        public AlarmClock(int hour, int minute)
        {
 
        }
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) 
        {
            hour = Hour;
            minute = Minute;
            alarmHour = AlarmHour;
            alarmMinute = AlarmMinute;
        }
        public bool TickTock(int hour, int minute, int alarmHour, int alarmMinute)  
        {
            minute++;
            if (minute == 60) 
            {
                minute = 0;
                hour++;
            }
            if (hour == 24) 
            {
                hour = 0;
            }
            if (hour == alarmHour && minute == alarmMinute) 
            {
                return true;
            }
            return false;
        }
        public string ToString(int hour, int minute, int alarmHour, int alarmMinute) 
        {
            if (minute > 10) 
            {
                return (hour + ":" + "0" + minute + " <" + alarmHour + ":" + alarmMinute + ">");
            }
            return (hour + ":" + minute + " <" + alarmHour + ":" + alarmMinute + ">");
        }
    }
 
}
