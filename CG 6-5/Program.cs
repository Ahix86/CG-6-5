using System;

namespace CG_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pease enter your birthday in MM/DD/YYYY format");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            //determine day of week birthdate isby pulling it from the given date and print it to console
            Console.WriteLine("You were born on a " + birthday.DayOfWeek);

            DateTime currentdate = DateTime.Now;
            //assign variable name and type to current date

            DateTime nextBDay = new DateTime(currentdate.Year, birthday.Month, birthday.Day);
            //create new datetime variable for birthday in current year to use in if/else if statements below

            //if day of year of your birthday is greater than or equal to current day of year,
            //the day of week will be determined by using current year
            //print day of the week to console using ToString
            if (birthday.DayOfYear >= currentdate.DayOfYear)
            {
                Console.WriteLine("Your next birthday will be on a {0}.", nextBDay.ToString("dddd"));
            }


            //if day of year of your birthday has happened already this year, add 1 year to date to get correct day
            //print to console using ToString
            else if (birthday.DayOfYear < currentdate.DayOfYear)
            {
                DateTime nextBDdayofwk = nextBDay.AddYears(1);
                Console.WriteLine("Your next birthday will be on a " + birthday.DayOfWeek);
            }

            // set the months and days to an int to call on below in number form
            int days = birthday.Day;
            int months = birthday.Month;

            // create a string to return the users horoscope based on their birthday
            string horoscope = " ";

            // set paramaters between dates that determine the users sign and horoscope
            //I used the && to say if it is this month and also less than or equal to this particular day
            if (months == 03 && days <= 21)
            {
                horoscope = " You are an Aries. \n You will win a big race soon";
            }

            else if (months == 04 && days <= 18)
            {
                horoscope = " You are an Aries. \n You will win a big race soon";
            }

            else if (months == 04 && days <= 20)
            {
                horoscope = " You are a Taurus. \n You will win on a scratcher ticket soon.";
            }

            else if (months == 05 && days <= 20)
            {
                horoscope = "You're a Taurs. \n You will win on a scratcher ticket soon.";
            }
            else if (months == 05 && days <= 21)
            {
                horoscope = "You are a Gemini. \n You will get a new job this year.";
            }

            else if (months == 06 && days <= 22)
            {
                horoscope = "You are a Gemini. \n You will get a new job this year.";
            }

            else if (months == 06 && days <= 21)
            {
                horoscope = "You are a Cancer. \n You will get a new house this year.";
            }
            else if (months == 07 && days <= 22)
            {
                horoscope = "You are a Cancer. \n You will get a new house this year.";
            }
            else if (months == 07 && days <= 23)
            {
                horoscope = "You are a Leo. \n You will get a lump of coal.";
            }
            else if (months == 08 && days <= 22)
            {
                horoscope = "You are a Leo. \n You will get a lump of coal.";
            }
            else if (months == 08 && days <= 23)
            {
                horoscope = "You are a Virgo. \n You will be granted three wishes.";
            }
            else if (months == 09 && days <= 22)
            {
                horoscope = " You are a Virgo. \n You will be granted three wishes.";

            }
            else if (months == 09 & days == 23)
            {
                horoscope = " You are a Libra. \n You will get a new car this year.";
            }
            else if (months == 10 && days <= 22)
            {
                horoscope = "You are a Libra. \n You will get a new car this year.";
            }
            else if (months == 10 && days <= 23)
            {
                horoscope = "You are a Scorpio. \n You will adopt a new pet.";
            }
            else if (months == 11 && days <= 21)
            {
                horoscope = "You are a Scorpio. \n You will adopt a new pet";
            }
            else if (months == 11 && days <= 22)
            {
                horoscope = "You are a Sagittarius. \n You will have a baby this year";
            }
            else if (months == 12 && days <= 21)
            {
                horoscope = "You are a Sagittarius. \n You will have a baby this year";
            }
            else if (months == 12 && days <= 22)
            {
                horoscope = "You are a Capricorn. \n You will adopt a baby this year";
            }
            else if (months == 01 && days <= 19)
            {
                horoscope = "You are a Capricorn. \n You will adopt a baby this year";
            }
            else if (months == 01 && days <= 20)
            {
                horoscope = "You are an Aquaris. \n You will take a grand vacation.";
            }

            else if (months == 02 && days <= 18)
            {
                horoscope = "You are an Aquarius. \n You will take a grand vacation.";
            }
            else if (months == 02 && days <= 19) 
            {
                horoscope = "You are a Pices. \n You will find gold";
            }
            else if (months == 03 && days <= 20)
            {
                horoscope = "You are a Pices. \n You will find gold";
            }

            //end all options and output the users horocope to them. 
            Console.WriteLine(horoscope);
            Console.ReadLine();

        }
    }
}
