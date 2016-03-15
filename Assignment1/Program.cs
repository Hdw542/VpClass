using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            getBirthDay();
        }
        public static void getBirthDay()
        {
            int siblings;
            Console.Out.WriteLine("Enter Number Of Siblings");
            siblings = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= siblings; i++)
            {
                Console.Out.WriteLine("Please enter date of birth of sibling "+i);
                DateTime date = DateTime.Parse(Console.ReadLine());
                int Day = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (date.Year * 365 + date.Day);
                int Year = Day / 365;
                //Console.Out.WriteLine("Year = "+Year);

                int Day1 = (DateTime.Now.Month * 30 + DateTime.Now.Day) - (date.Month * 30 + date.Day);
                int month = Day1 / 30;
                month = Math.Abs(month);
                //Console.Out.WriteLine("Month = "+month);

                int Day2 = (DateTime.Now.Day * 30 + DateTime.Now.Day) - (date.Day * 30 + date.Day);
                int Day3 = Day2 / 30;
                //Console.Out.WriteLine("Days = "+Day3);
                Console.Out.WriteLine("Age of sibling "+ i +" is " + Year + "Years " + month + " months " + Day3 + " days");
                
                // testing differene code
                //TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
                /*
                System.TimeSpan diff = secondDate.Subtract(firstDate);
                System.TimeSpan diff1 = secondDate - firstDate;
                 */ 
            }
            Console.ReadLine();
        }
    }
}
