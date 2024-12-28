using System;

namespace ConsoleApp1
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public enum Colors
    {
        Red,
        Green,
        Blue
    }
    class Program
    {
         static void Main(string[] args)
        {
            #region  Q1

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
            #region  Q2

            Console.Write("Enter the season: ");
            string userInput = Console.ReadLine();

            if (Enum.TryParse(userInput, true, out Season season))
            {
              
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        #endregion
        #region  Q3



        #endregion
        #region  Q4
        
        #endregion

    }
}

