using System;
using System.ComponentModel;


namespace assingnment4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = {0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2};
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            Console.WriteLine("Welcome to Assignment4");
            Console.WriteLine("Hit enter to get start ");
            Console.ReadLine();

            for (int k = 0; k < 4; k++)
            {



                Console.WriteLine(
                    "\nPlease Type the question number to jump to that particular question or type number > 6 to exit");
                int quesNum = int.Parse(Console.ReadLine());
                switch (quesNum)
                {
                    case 1:
                        Console.WriteLine("First Question Begins\n");
                        foreach (char lett in letters)
                        {
                            Console.Write(lett);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Second Question Begins\n");
                        Array.Reverse(poem);
                        foreach (string word in poem)
                        {

                            Console.Write(word);

                        }
                        break;
                    case 3:
                        Console.WriteLine("Third Question Begins\n");
                        Console.WriteLine();
                        for (int i = poem.Length - 1; i >= 0; i--)
                        {
                            Console.WriteLine(poem[i]);

                        }
                        break;


                    case 4:
                        Console.WriteLine("\nFourth Question Begins\n");
                        Array.Sort(poem);

                        foreach (string alphabet in poem)
                        {
                            Console.WriteLine(alphabet);
                        }
                        break;

                    case 5:
                        Console.WriteLine("\nFifth Question Begins");
                        Array.Sort(numbers);

                        int num = Array.BinarySearch(numbers, 6);
                        Console.WriteLine("The position for the entered number is " + num);
                        break;

                    case 6:
                        Console.WriteLine("\nSixth Question Begins\n");
                        Console.WriteLine("Please input a number for the length of an array");
                        int input = int.Parse(Console.ReadLine());

                        string[] posInt = new string[input];






                        for (int j = 0; j < posInt.Length; j++)
                        {
                            Console.WriteLine("\nEnter an element\n");
                            posInt[j] = Console.ReadLine();
                        }



                        for (int a = 0; a < posInt.Length; a++)
                        {
                            Console.Write(" " + posInt[a]);
                        }
                        break;
                    default:
                    {
                        Console.WriteLine("Thank you ...See you later");
                    }
                        break;

                }
                Console.ReadKey();


            }
        }
    }

}













