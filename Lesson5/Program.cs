using System;

namespace Lesson5
{
    class Program
    {
        static void Dogs()
        {
            Dog dog1 = new Dog("Sharo", "Street Universal");
            dog1.Bark();

        }

        static void Persons()
        {
            Person person1 = new Person();
            Console.WriteLine("\nName?");
            person1.Name = Console.ReadLine();
            Console.WriteLine("\nAge?");
            person1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEmail?");
            person1.Email = Console.ReadLine();
            if (person1.Email.Contains("@") == false)
            {
           
             Console.WriteLine("\n Invalid Email");
            }
            Console.WriteLine(person1.ToString());
        }

        static void LaptopShop()
        {
            Laptop ordi = new Laptop(/*parameters*/);
            Console.WriteLine(ordi.ToString());
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine(
                                 "\nTask 1 : \n\n"
                                 + "1 : Dog Bark\n"

                                 + "\nTask 2 :\n\n"
                                 + "2 : Persons \n"

                                  + "\nTask 3 :\n\n"

                                 + "3 : Laptop Shop \n"

                                 + "\nPlease choose : ");
                int exo = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Dogs();
                        break;
                    case 2:
                        Persons();
                        break;
                    case 3:
                        LaptopShop();
                        break;


                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }

    }
}
