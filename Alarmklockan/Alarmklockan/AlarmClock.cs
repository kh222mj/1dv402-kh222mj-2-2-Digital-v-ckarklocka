﻿using System;
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
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");
                }
                _alarmHour = value;
            }
        }
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                _alarmMinute = value;
            }
        }
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23");
                }
                _hour = value;
            }
        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59");
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
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }
        public bool TickTock()
        {
            if (Minute < 59)
            {
                Minute++;
            }
            else
            {
                Minute = 0;
                if (Hour < 23)
                {
                    Hour++;
                }
                else
                {
                    Hour = 0;
                }
            }

            return Hour == AlarmHour && Minute == AlarmMinute;
        }
        public override string ToString()
        {
            Console.ResetColor();
            if (_alarmHour == 0 && _alarmMinute == 0)
            {
                return String.Format("{0,4}:{1:00} <{2}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
            }
            if (_hour == _alarmHour && _minute == _alarmMinute)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                return String.Format("♫{0,3}:{1:00} <{2}:{3:00}>   BEEP! BEEP! BEEP! BEEP!", _hour, _minute, _alarmHour, _alarmMinute);
            }
            return String.Format("{0,4}:{1:00} <{2}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
        }
    }
}