using System;

namespace CG_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for their birthday and store it
            Console.WriteLine("Please enter the date you were born in MM/DD/YYYY format: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //tell the user what day of the week they were born on and what day that will be next year
            Console.WriteLine($"You were born on a {birthDate.DayOfWeek} and your next birthday will be {birthDate.AddYears(1).DayOfWeek} .");
            Console.ReadLine();

            //because I chose to use a method, I needed to declare the variables I was using here.
            int birthMonth = birthDate.Month;
            int birthDay = birthDate.Day;

            //call the method and print the appropriate response to the screen
            Console.WriteLine(Zodiac(birthMonth, birthDay));
            Console.ReadLine();
        }
        /// <summary>
        /// use the user's birthdate to assign a zodiac sign and return a horoscope
        /// </summary>
        /// <param name="birthMonth"></param>
        /// <param name="birthDay"></param>
        /// <returns>a zodiac sign and horoscope</returns>
        private static string Zodiac(int birthMonth, int birthDay)

        {
            //else/if statements to compare the user's birthdate to the options for zodiac signs, starting with the first sign listed in bing search
            //each statement finds if the birth month listed is true and if it is, whether it is within certain dates listed. These dates determine the sign
            if ((birthMonth == 3 && birthDay >= 21) || (birthMonth == 4 && birthDay <= 19))
                return "Your Zodiac sign is Aries. Your horoscope is: You will find a great fortune next year!";



            else if ((birthMonth == 4 && birthDay >= 20) || (birthMonth == 5 && birthDay <= 20))

                return "Your Zodiac sign is Taurus. Your horoscope is: You will find your true love tomorrow";



            else if ((birthMonth == 5 && birthDay >= 21) || (birthMonth == 6 && birthDay <= 20))

                return "Your Zodiac sign is Gemini. Your horoscope is: Go to the movies and relax this week.";



            else if ((birthMonth == 6 && birthDay >= 21) || (birthMonth == 7 && birthDay <= 22))

                return "Your Zodiac sign is Cancer. Your horoscope is: You will go on an amazing adventure in two weeks.";



            else if ((birthMonth == 7 && birthDay >= 23) || (birthMonth == 8 && birthDay <= 22))

                return "Your Zodiac sign is Leo. Your horoscope is: You will find $40.00 next month.";


            else if ((birthMonth == 8 && birthDay >= 23) || (birthMonth == 9 && birthDay <= 22))

                return "Your Zodiac sign is Virgo. Your horoscope is: Try out for a local choir. The results may surprise you!";



            else if ((birthMonth == 9 && birthDay >= 23) || (birthMonth == 10 && birthDay <= 22))

                return "Your Zodiac sign is Libra. Your horoscope is: Go to a concert and you will meet a new friend!";



            else if ((birthMonth == 10 && birthDay >= 23) || (birthMonth == 11 && birthDay <= 21))

                return "Your Zodiac sign is Scorpio. Your horoscope is: Try a new game this weekend with friends.";



            else if ((birthMonth == 11 && birthDay >= 22) || (birthMonth == 12 && birthDay <= 21))

                return "Your Zodiac sign is Sagittarius. Your horoscope is: Pick a new recipe and try it out! Your skills may surprise you.";



            else if ((birthMonth == 12 && birthDay >= 22) || (birthMonth == 1 && birthDay <= 19))

                return "Your Zodiac sign is Capricorn. Your horoscope is: You will have a new pet within a year.";



            else if ((birthMonth == 1 && birthDay >= 20) || (birthMonth == 2 && birthDay <= 18))

                return "Your zodiac sign is Aquarius. Your horoscope is: Don't be afraid to chase the new opportunity that appears next week.";



            else if ((birthMonth == 2 && birthDay >= 19) || (birthMonth == 3 && birthDay <= 20))

                return "Your zodiac sign is Pisces. Your horoscope is: Take your family to the movies and have fun!";



            else

                return "That is not a valid response.";





        }

    }
}
