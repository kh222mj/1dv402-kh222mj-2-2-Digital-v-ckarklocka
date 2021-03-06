﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmklockan
{
    class Program
    {
        private static void Run(AlarmClock ac, int minutes) 
        {
            int i = 0;
            while(i < minutes)
            {             
                ac.TickTock();
                i++;
                Console.WriteLine(ac.ToString());
            }
        }
        private static void ViewErrorMessage(string message) 
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void ViewTestHeader(string message) 
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();
            int minutes;
            string HorizontalLine = "-------------------------------------------------------------------------------";
            
            //Test 1
            Console.WriteLine("Test 1");
            Console.WriteLine("Test av stadardkonstruktorn.");
            Console.WriteLine("");//Blankrad
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine(HorizontalLine);

            //Test 2
            Console.WriteLine("Test 2");
            Console.WriteLine("Test av konstruktorn med två parametrar.");
            alarmClock.Hour = 9;
            alarmClock.Minute = 42;
            Console.WriteLine("");//Blankrad
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine(HorizontalLine);

            //Test 3
            Console.WriteLine("Test 3");
            Console.WriteLine("Test av konstruktorn med tre parametrar, <13, 24, 7, 35>.");
            alarmClock.Hour = 13;
            alarmClock.Minute = 24;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;
            Console.WriteLine("");//Blankrad
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine(HorizontalLine);

            //Test 4
            Console.WriteLine("Test 4");
            Console.WriteLine("Ställer befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            Console.WriteLine("");//Blankrad
            alarmClock.Hour = 23;
            alarmClock.Minute = 58;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;
            minutes = 13;
            Run(alarmClock, minutes);
            Console.WriteLine(HorizontalLine);
          
            //Test 5
            Console.WriteLine("Test 5");
            Console.WriteLine("Ställer befintligt AlarmClock-objekt till 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter");
            Console.WriteLine("");//Blankrad
            alarmClock.Hour = 6;
            alarmClock.Minute = 12;
            alarmClock.AlarmHour = 6;
            alarmClock.AlarmMinute = 15;
            minutes = 6;
            Run(alarmClock, minutes);
            Console.WriteLine(HorizontalLine);

            //Test 6
            Console.WriteLine("Test 6");
            Console.WriteLine("Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            Console.WriteLine("");//Blankrad
            try
            {
                alarmClock.Hour = 2000;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                alarmClock.AlarmHour = 2000;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            Console.WriteLine(HorizontalLine);

            //Test 7
            Console.WriteLine("Test 7");
            Console.WriteLine("Testar Konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            Console.WriteLine("");//Blankrad
            try
            {
                new AlarmClock(0, 0, 200, 0);
            }
            catch (Exception ex)
            {
                ViewTestHeader(ex.Message);
            }
            try
            {
                new AlarmClock(0, 0, 0, 200);
            }
            catch (Exception ex)
            {
                ViewTestHeader(ex.Message);
            }
            try
            {
                new AlarmClock(200, 0, 0, 0);
            }
            catch (Exception ex)
            {
                ViewTestHeader(ex.Message);
            }
            try
            {
                new AlarmClock(0, 200, 0, 0);
            }
            catch (Exception ex)
            {
                ViewTestHeader(ex.Message);
            }
            Console.WriteLine(HorizontalLine);           
        }
    }
}


