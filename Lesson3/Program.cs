using System;
using System.Collections.Generic;
using System.Collections;

namespace Lesson3
{
    class Program
    {
        static void Triangles()
        {

            Console.WriteLine("Side a of the triangle ? ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Side b of the triangle ? ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Side c of the triangle ? ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b || a == c || c == b)
            {
                Console.WriteLine("Two of the sides are equal\n");
                if (a == b) 
                    Console.WriteLine("Side a and side b are equal");
                if (b == c)
                    Console.WriteLine("Side b and side c are equal");
                if (c == a)
                    Console.WriteLine("Side c and side a are equal");

            }
            if (a.Equals(b) == true && a.Equals(c) == true)
            {
                Console.WriteLine("The 3 sides are equal");
                Console.WriteLine("Side a, side b and side c are equal");
            }

        }

        static void Numbers()
        {

            List<int> numbers = new List<int>();

            Console.WriteLine("Write a number between 10 and 20");
            int nbr = int.Parse(Console.ReadLine());
            if (nbr >= 10 && nbr <= 20)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Write another number between 10 and 20");
                    int nbr2 = int.Parse(Console.ReadLine());
                    if (nbr2 >= 10 && nbr2 <= 20)
                    {
                        numbers.Add(nbr2);
                    }
                }

                foreach (var item in numbers)
                    Console.WriteLine(item);

                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"\nSum : {sum}\n");
            }
            else
                Console.WriteLine("The number entered isn't between 10 and 20");
        }

        static void SportSelector()
        {
            Console.WriteLine("\nHeight (in cm)?");
            decimal height = decimal.Parse(Console.ReadLine());
            if (height >= 190)
                Console.WriteLine("\nBasketball");
            else if (height <= 175)
                Console.WriteLine("\nHorse riding");
            else if (height >= 175 && height <= 190)
                Console.WriteLine("\nAthletics");

        }

        static void Greeting()
        {
            Console.WriteLine("Day number (1-7) ?");
            int daynumber = int.Parse(Console.ReadLine());
            string weekdayname = GetDayOfTheWeek(daynumber);
            Console.WriteLine("Hour number (0-24) ?");
            int hournumber = int.Parse(Console.ReadLine());
            string hour = GetPartoftheDay(hournumber);

            string periodtotheweekend = Getperiodtotheweekend(daynumber);

            Console.WriteLine($"Good{hour}, it is a lovely {weekdayname} today. {periodtotheweekend}");
        }
        private static string GetDayOfTheWeek(int daynumber)
        {
            switch (daynumber)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Error!";
            }
        }
        private static string GetPartoftheDay(int hour)
        {
            if (hour < 6 || hour > 20)
            {
                return "night";
            }
            else if (hour < 10)
            {
                return "morning";
            }
            else if (hour < 16)
            {
                return "day";
            }
            else
            {
                return "evening";
            }
        }
        private static string Getperiodtotheweekend(int daynumber)
        {
            switch (daynumber)
            {
                case 1: return $"Weekend is coming in {6 - daynumber}";

                case 2: return $"Weekend is coming in {6 - daynumber}";

                case 3: return $"Weekend is coming in {6 - daynumber}";

                case 4: return $"Weekend is coming in {6 - daynumber}";

                case 5:
                    return $"Weekend is coming in {6 - daynumber}";

                case 6: return "Weekend is here";

                case 7:
                    return "Weekend is here";

                default:
                    return "It is knknown time of the week";
            }
        }
        static void FormValidation()
        {
            Console.WriteLine("First name ?");
            string firstname = Console.ReadLine();
            if (firstname.Length > 100)
                Console.WriteLine("Too long !");
            Console.WriteLine("Last name ?");
            string lastname = Console.ReadLine();
            if (lastname.Length > 100)
                Console.WriteLine("Too long !");
            Console.WriteLine("Date of birth (dd/mm/yyyy) ?");
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date.Year < 1920)
                Console.WriteLine("Invalid date !");


            Console.WriteLine("Student number (year) ?");

            int[] studentnbr_ = new int[4];
            int saisie = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                studentnbr_[i] = saisie;
            }
            for (int i = 0; i < studentnbr_.Length; i++)
            {
                Console.WriteLine(studentnbr_[i]);

            }

            //..........................................




        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Task 1 : Triangles"

                                   + "\n\n Task 2 : Numbers"
                                   + "\n\n Task 3 : Sport selector"
                                   + "\n\n Task 4 : Greeting"
                                   + "\n\n Task 5 : Form validation"
                                   + "\n\n Please choose : ");

                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Triangles();
                        break;

                    case 2:
                        Numbers();
                        break;

                    case 3:
                        SportSelector();
                        break;

                    case 4:
                        Greeting();
                        break;
                    case 5:
                        FormValidation();
                        break;

                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }

}
