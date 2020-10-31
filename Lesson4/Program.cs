using System;

namespace Lesson4
{
    class Program
    {
        static string Encode(string saisie, char[] alphabet, char[] random)
        {
            string Encoded_Message = "";
            int index = -1;

            for (int i = 0; i < saisie.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (saisie[i] == alphabet[j])
                        index = j;
                } 
                Encoded_Message += random[index];

            }
            return Encoded_Message;
        }
         
        static string Decode(string saisie, char[] alphabet, char[] random)
        {
            string Decoded_message = "";
            int index = -1;
             
            for (int i = 0; i < saisie.Length; i++)
            { 
                for (int j = 0; j < random.Length; j++)
                {
                    if (saisie[i] == random[j])
                        index = j;
                }
                Decoded_message += alphabet[index];

            }
            return Decoded_message;
        }

        static void Diamond()
        {

            double n = 5;
            double i, j, k;

            //first half
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }

            //last half
            for (i = 4; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }

        }

        static void Tasks()
        {

            ////////// sum and average of 10 numbers
            double sum = 0;
            for (int b = 0; b < 10; b++)
            {
                Console.WriteLine("Enter a number");
                double _nbr = double.Parse(Console.ReadLine());
                sum += _nbr;
            }
            Console.WriteLine($"\nSum : {sum} \nAverage : {sum / 10}");


            ///////////  right angle triangle

            double i, j, k;
            Console.WriteLine("\nTriangle height ?");
            double n = int.Parse(Console.ReadLine());

            for (i = 0; i <= n + 1; i++)
            {
                for (j = 1; j <= n + 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            ///////////  pyramid
            Console.WriteLine("\n Pyramid height ?");
            int h = int.Parse(Console.ReadLine());

            for (i = 0; i <= h + 1; i++)
            {
                for (j = 1; j <= h + 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            ///////////   factorial
            Console.WriteLine("\n Number ?");
            int nbr = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int l = 1; l <= nbr; l++)
            {
                fact = fact * l;
            }
            Console.WriteLine($"\n Factorial : {fact}");


            /////////// 9 + 99 + 999 + 9999 .....
            Console.WriteLine(" \n Number of terms :");
            int sum_ = 0;
            int t = 0;
            int terms = int.Parse(Console.ReadLine());
            for (int f = 1; f < terms; f++)
            {
                sum_ += t;
                Console.WriteLine(t);
                t = t * 10 + 9;
            }
            Console.WriteLine($"\nSum : { sum_}");

        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Homework 1 : Diamond"
                    + "\n\n Homework  2 :\n 2 : Encode message\n 3 : Decode message"

                    + "\n\n Tasks : 4 "
                                   + "\n\n Please choose : ");

                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Diamond();
                        Console.ReadKey();
                        break;

                    case 2:
                        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };
                        char[] random = { 'C', 'Q', 'L', 'K', 'U', 'W', 'R', 'D', 'E', 'P', 'J', 'G', 'A', 'Z', 'H', 'Y', 'B', 'M', 'S', 'T', 'I', 'V', 'N', 'X', 'F', 'O', ' ' };

                        Console.WriteLine("Message : ");
                        string saisie = Console.ReadLine();
                        saisie = saisie.ToUpper();
                        Console.WriteLine($"Encoded message : { Encode(saisie, alphabet, random)}");
                        Console.ReadKey();
                        break;

                    case 3:
                        char[] alphabet_ = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };
                        char[] random_ = { 'C', 'Q', 'L', 'K', 'U', 'W', 'R', 'D', 'E', 'P', 'J', 'G', 'A', 'Z', 'H', 'Y', 'B', 'M', 'S', 'T', 'I', 'V', 'N', 'X', 'F', 'O', ' ' };

                        Console.WriteLine("Message : ");
                        string saisie_ = Console.ReadLine();
                        saisie_ = saisie_.ToUpper();
                        Console.WriteLine($"Decoded message : { Decode(saisie_, alphabet_, random_)}");
                        Console.ReadKey();
                        break;

                    case 4:
                        Tasks();
                        Console.ReadKey();
                        break;

                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }

}
