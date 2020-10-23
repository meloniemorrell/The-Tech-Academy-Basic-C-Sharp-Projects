using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM254
{
    class Program
    {
        enum WeekDays
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            bool inValidDay = true;
            do
            {
                Console.Write("Enter the current day of the week? ");
                string day = Console.ReadLine();
                //conver to lower case
                day = day.ToLower();

                try
                {
                    WeekDays dow = (WeekDays)Enum.Parse(typeof(WeekDays), day);
                    inValidDay = false;
                }
                catch (Exception )
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            } while (inValidDay);
        }
    }
}