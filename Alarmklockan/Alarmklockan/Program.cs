using System;
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
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();
            int minutes;
            
            //Test 1
            Console.WriteLine("Test 1");
            Console.WriteLine("Test av stadardkonstruktorn.");
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine("");//Blankrad

            //Test 2
            Console.WriteLine("Test 2");
            Console.WriteLine("Test av konstruktorn med två parametrar.");
            alarmClock.Hour = 9;
            alarmClock.Minute = 42;
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine("");//Blankrad

            //Test 3
            Console.WriteLine("Test 3");
            Console.WriteLine("Test av konstruktorn med tre parametrar, <13, 24, 7, 35>.");
            alarmClock.Hour = 13;
            alarmClock.Minute = 24;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;
            Console.WriteLine(alarmClock.ToString());
            Console.WriteLine("");//Blankrad

            //Test 4
            Console.WriteLine("Test 4");
            Console.WriteLine("Ställer befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            Console.WriteLine("");//Blankrad
            alarmClock.Hour = 23;
            alarmClock.Minute = 58;
            alarmClock.AlarmHour = 7;
            alarmClock.AlarmMinute = 35;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ║        Modellnr.: 1DV402S2L2A        ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            minutes = 13;
            Run(alarmClock, minutes);
            Console.WriteLine("");//Blankrad
          
            //Test 5
            Console.WriteLine("Test 5");
            Console.WriteLine("Ställer befintligt AlarmClock-objekt till 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter");
            Console.WriteLine("");//Blankrad
            alarmClock.Hour = 6;
            alarmClock.Minute = 12;
            alarmClock.AlarmHour = 6;
            alarmClock.AlarmMinute = 15;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ║        Modellnr.: 1DV402S2L2A        ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            minutes = 6;
            Run(alarmClock, minutes); 
        }
    }
}
