using System;

namespace LesVandaag
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            int day = (int)DateTime.Now.DayOfWeek;
            string uitvoer = "";
            switch (day.ToString()) {
                case "0":
                    {
                        uitvoer = "Geen les"; break;
                    }
                case "1": 
                    { 
                        uitvoer = "C# lessen"; break; 
                    } 
                case "2": 
                    { 
                        uitvoer = "Project"; break; 
                    } 
                case "3": 
                    { 
                        uitvoer = "Keuzedeel"; break; 
                    } 
                case "4": 
                    { 
                        uitvoer = "HTLM-CSS"; break; 
                    } 
                case "5": 
                    { 
                        uitvoer = "Python"; break; 
                    }
                case "6":
                    {
                        uitvoer = "Geen les"; break;
                    }
            }
            Console.WriteLine("Op " + vandaag.DayOfWeek + " heb je " + uitvoer + "."); Console.ReadKey();

        }
    }
}
