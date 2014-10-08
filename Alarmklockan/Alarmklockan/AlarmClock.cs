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
                if (value > 24 && value < 0)
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
                if (value > 60 || value < 0)
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
                if (value > 24 && value < 0)
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
                if (value > 60 || value < 0)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }
        public AlarmClock() 
            : this(0, 0)
        {

        }
        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {

        }
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) 
        {
            hour = Hour;
            minute = Minute;
            alarmHour = AlarmHour;
            alarmMinute = AlarmMinute;
        }
        public bool TickTock()  
        {
            Minute++;
            
            if (Minute == 60) 
            {
                Minute = 0;
                Hour++;
            }
            if (Hour == 24) 
            {
                Hour = 0;
            }
            if (Hour == AlarmHour && Minute == AlarmMinute) 
            {
                return true;
            }
            return false;
        }
        public string ToString() 
        {
            Console.ResetColor();
            if (_minute == _alarmMinute && _hour == _alarmHour) 
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                if (_minute < 10)
                {
                    return (_hour + ":" + "0" + _minute + " <" + _alarmHour + ":" + _alarmMinute + ">" + "   BEEP!  BEEP!  BEEP!  BEEP!");
                }
                    return (_hour + ":" + _minute + " <" + _alarmHour + ":" + _alarmMinute + ">" + "   BEEP!  BEEP!  BEEP!  BEEP!");
            }    
            if (_minute < 10) 
            {
                return (_hour + ":" + "0" + _minute + " <" + _alarmHour + ":" + _alarmMinute + ">");
            }
            return (_hour + ":" + _minute + " <" + _alarmHour + ":" + _alarmMinute + ">");
        }
    }
 
}
