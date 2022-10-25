using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab4 : ILabs
    {
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            int n = 5;
            int[] mass = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 101);
                Console.Write(mass[i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("Задание 2");
            string str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Задание 3");  
            int buffer = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        buffer = mass[i];
                        mass[i] = mass[j];
                        mass[j] = buffer;
                    }
                }
                Console.Write(mass[i] + "\t");
            }

            Console.WriteLine();
        }

        public string Description()
        {
            return "Задания лабораторной №4";
        }

        public int Id()
        {
            return 4;
        }

        public string Name()
        {
            return "Массивы. Строки";
        }
    }
}
