using System;

namespace Survey
{
    class Sup
    {
        static public string Ask(string question)
        {
            Console.Write(question);
            question =Console.ReadLine();

            if (question == "")
            {
                question = TryAgain();

            }
            return question;
        }
        static string TryAgain()
        {
            Console.WriteLine("You didn't type anything, please try again:");
            return Console.ReadLine();
        }
        static public string Zodiac(string month, int day)
        {
            string zodiac = "";
            month.ToLower();
            switch (month)
            {
                case "january":
                    if (0 <= day && day <= 19)
                    {
                        zodiac = "Capricorn";
                    }
                    else if (20 <= day && day <= 31)
                    {
                        zodiac = "Aquarius";
                    }
                    break;
                case "february":
                    if (0 <= day && day <= 19)
                    {
                        zodiac = "Aquarius";
                    }
                    else if (20 <= day && day <= 28)
                    {
                        zodiac = "Pisces";
                    }
                    break;
                case "march":
                    if (0 <= day && day <= 20)
                    {
                        zodiac = "Pisces";
                    }
                    else if (21 <= day && day <= 31)
                    {
                        zodiac = "Aries";
                    }
                    break;
                case "april":
                    if (0 <= day && day <= 19)
                    {
                        zodiac = "Aries";
                    }
                    else if (20 <= day && day <= 30)
                    {
                        zodiac = "Taurus";
                    }
                    break;
                case "may":
                    if (0 <= day && day <= 20)
                    {
                        zodiac = "Taurus";
                    }
                    else if (21 <= day && day <= 31)
                    {
                        zodiac = "Gemini";
                    }
                    break;
                case "june":
                    if (0 <= day && day <= 21)
                    {
                        zodiac = "Gemini";
                    }
                    else if (21 <= day && day <= 30)
                    {
                        zodiac = "Cancer";
                    }
                    break;
                case "july":
                    if (0 <= day && day <= 22)
                    {
                        zodiac = "Cancer";
                    }
                    else if (21 <= day && day <= 30)
                    {
                        zodiac = "Leo";
                    }
                    break;

            }
            
            return zodiac;
        }
    }
        
}
