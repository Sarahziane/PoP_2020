using System;

namespace Lesson2
{

    class Program
    {
        static void MeAfter10()
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            age += 10;
            Console.WriteLine("In 10 years, you'll be " + age + "years old.");
        }

        static void Rectangle()
        { 
            Console.WriteLine("Width of the rectangle?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length of the rectangle?");
            int length = Convert.ToInt32(Console.ReadLine());
            int area = width * length;
            Console.WriteLine("area : " + area);

            int perimeter = 2 * width + 2 * length;
            Console.WriteLine("perimeter : " + perimeter);
        }
        static void Triangle()
        {
            Console.WriteLine("Width of the triangle?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length of the triangle?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height of the triangle?");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = width * length / 2;
            Console.WriteLine("area : " + area);

            int perimeter = width + length + height;
            Console.WriteLine("perimeter : " + perimeter);
        }
        static void Circle()
        {
            Console.WriteLine("Radius of the circle?");
            double radius = Convert.ToInt32(Console.ReadLine());
            double area = radius * radius * Math.PI;

            double perimeter = 2 * radius * Math.PI;
            Console.WriteLine("perimeter : " + perimeter);
        }

        static void Date_and_Time()
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t);
        }
        static void Dateafter10()
        {
            DateTime d = new DateTime(2020, 10, 05);
            Console.WriteLine("In 10 years, the date will be : " + d.AddYears(10));

        }
        static void DateafterXyears()
        {
            Console.WriteLine("How many years?");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime d = new DateTime(2020, 10, 05);
            Console.WriteLine("In " + x + " years, the date will be : " + d.AddYears(x));
        }

        static void Future_birthday()
        {
            Console.WriteLine("user's current age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user's future age :");
            int future_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user's birthday month : ");
            int birthday_month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user's birthday day :");
            int birthday_day = Convert.ToInt32(Console.ReadLine());

            DateTime future_bday = new DateTime(2020, 10, 05);
            Console.WriteLine("The future birthday will be : " + future_bday.AddYears(future_age - age));
        }

        static void Print_hello()
        {
            Console.WriteLine("Hello\nSarah Ziane");
        }
        static int Sum(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        static void Operations()
        {
            int op1 = -1 + 4 * 6;
            Console.WriteLine("-1 + 4 * 6 = " + op1);
            int op2 = (35 + 5) % 5;
            Console.WriteLine("(35 + 5) % 5 = " + op2);
            int op3 = 14 + (-4) * 6 / 11;
            Console.WriteLine("14 + (-4) * 6 / 11 = " + op3);
            int op4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + op4);
        }

        static void Multiplication_tables()
        {
            Console.WriteLine("Number?");
            int nbr = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(nbr + " * " + i + " = " + nbr * i);
            }
        }
        static void Average()
        {
            Console.WriteLine("Number n°1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number n°2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number n°3 : ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number n°4 : ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 * n2 * n3 * n4 / 4);
        }
        static void WithinRange()
        {
            bool result = false;
            Console.WriteLine("Number?");
            int nbr = Convert.ToInt32(Console.ReadLine());
            if (nbr < 200 && nbr > 100)
                result = true;
            else
                result = false;
            Console.WriteLine(result);
        }
        static int YearofBirth(int age)
        {
            int year = 2020;
            year = 2020 - age;
            return year;
        }

        static void Operations2()
        {
            Console.WriteLine("x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z : ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(x+y)z = " + (x + y) * z);
            Console.WriteLine("(xy) + (yz) = " + (x * y) + (y * z));

        }

        static void Detailled_date()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(" Day : " + d.Day + "\n Month : " + d.Month + "\n Year : " + d.Year);
            // DateTime.Now.Day

        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine(
                                 "\nTask 1 : \n\n"
                                 + "1 : Me After 10\n"

                                 + "\nTask 2 :\n\n"
                                 + "2 : Rectangle \n"
                                 + "4 : Triangle\n"
                                 + "6 : Circle\n"

                                 + "\n Task 3 : \n\n"
                                 + "8 : Current date and time\n"
                                 + "9 : Date in 10 years\n"
                                 + "10 : Date in x years\n"

                                 + "\n Task 4 : \n\n"
                                 + "11 : User's future birthday\n"

                                 + "\n Homework : \n\n"
                                 + "12 : Print hello\n"
                                 + "13 : Sum of two numbers\n"
                                 + "14 : Operations\n"
                                 + "15 : Multiplication\n"
                                 + "16 : Number's multiplication table\n"
                                 + "17 : Average of 4 numbers\n"
                                 + "18 : Between 100-200?\n"
                                 + "19 : Date separating day, month, year\n"
                                 + "20 : Year of birth\n"

                                 + "21 : Output of (x+y)z and xy + yz\n"

                                 + "\nPlease choose : ");
                int exo = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        MeAfter10();
                        break;

                    case 2:
                        Rectangle();
                        break;

                    case 4:
                        Triangle();
                        break;

                    case 6:
                        Circle();
                        break;

                    case 8:
                        Date_and_Time();
                        break;

                    case 9:
                        Dateafter10();
                        break;
                    case 10:
                        DateafterXyears();
                        break;

                    case 11:
                        Future_birthday();
                        break;
                    case 12:
                        Print_hello();
                        break;
                    case 13:
                        Console.WriteLine("Number n°1 : ");
                        int nbr1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Number n°2 : ");
                        int nbr2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Sum(nbr1, nbr2));

                        break;
                    case 14:
                        Operations();

                        break;
                    case 15:
                        Console.WriteLine("Number n°1 : ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Number n°2 : ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Number n°3 : ");
                        int n3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(n1 * n2 * n3);

                        break;
                    case 16:
                        Multiplication_tables();
                        break;
                    case 17:
                        Average();
                        break;
                    case 18:
                        WithinRange();
                        break;
                    case 19:
                        Detailled_date();
                        break;
                    case 20:
                        Console.WriteLine("Enter your age : ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Year of birth : " + YearofBirth(age));
                        break;
                    case 21:
                        Operations2();

                        break;

                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
