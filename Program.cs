using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentYear = DateTime.Today.Year;
            // Ask user for name
            var name = Sup.Ask("What is your name? ");
            // Ask user for age            
            var age = int.Parse(Sup.Ask("What is your age? "));
            // Ask user for month
            var month = Sup.Ask("What is your birth month? ");
            //Ask birth day
            var day = int.Parse(Sup.Ask("What day where you born? "));
            var zodiac = Sup.Zodiac(month, day);
            Console.WriteLine(zodiac);
            // print the information
            Console.WriteLine("Your name is: {0} \n you were born on {1} {2}, {3} your Zodiac is {4}", name, month, day,(CurrentYear-age), zodiac);
          
            
        }

        
    }
}
