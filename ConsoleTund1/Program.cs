using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

namespace ConsoleTund1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 30);
            Console.WriteLine(a);
            string text = "";
            if (a >= 1 && a <= 10)
            {
                text = "1 Desjatok";
            }
            else if (a >= 11 && a <= 30)
            {
                text = "2 Desjatok";
            }
            else if (a >= 21 && a <= 30)
            {
                text = "3-i Desjatok";
            }
            StreamWriter file=new StreamWriter(@"..\..\text.txt",true);
            file.WriteLine(text);
            file.Close();
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.Clear();
            StreamReader filest = new StreamReader(@"..\..\text.txt");
            text = filest.ReadToEnd();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Failis oli text:\n{0}", text);

            int[] numbers = new int[5] {1, 2, 3, 4, 5};
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }

            int[] numbers2 = new int[6];
            for (int ii = 0; ii < numbers2.Length; ii++)
            {
                numbers2[ii] = rnd.Next(1,10);
                Console.Write(numbers2[ii]);
            }
            Console.WriteLine();
            int[,] numbers3 = new int [4,10];
            for (int i1 = 0; i1 < numbers3.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < numbers3.GetLength(1); j1++)
                {
                    numbers3[i1, j1] = 1;
                    Console.Write(numbers3[i1, j1]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}