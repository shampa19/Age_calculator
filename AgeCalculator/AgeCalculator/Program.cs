using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter your Date of Birth:");
             DateTime dateOfBith = Convert.ToDateTime( Console.ReadLine());

             DateTime date1 = DateTime.Now;

            TimeSpan diff1 = date1 - dateOfBith;
            DateTime Age = DateTime.MinValue + diff1;
          

            int Years = Age.Year - 1;
            int Months = Age.Month - 1;
            int Days = Age.Day - 1;
            Console.Write(Days.ToString() + " Days " + Months.ToString() + " Months, " + Years.ToString() + " Years, " );

        }
    }
}
