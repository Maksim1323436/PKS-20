using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal class Lab2 : ILabs
    {
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число от 1 до 7");
            int num = 0;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out num);
                if ((res == true) && (num >= 1) && (num <= 7))
                {
                    break;
                }


            }
            string day = "";
            if (num == 1)
                day = "Понедельник";
            else if (num == 2)
                day = "Вторник";
            else if (num == 3)
                day = "Среда";

            else if (num == 4)
                day = "Четверг";

            else if (num == 5)
                day = "Пятница";

            else if (num == 6)
                day = "Суббота";

            else if (num == 7)
                day = "Воскресенье";
            Console.WriteLine(day);

            switch (num)
            {
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;
                case 7:
                    day = "Воскресенье";
                    break;
            }
            Console.WriteLine(num);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число");
            int number;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out number);
                if (res == true)
                    break;
            }
            int a = number;

            Console.WriteLine("Введите действие");
            string act;

            while (true)
            {
                act = Console.ReadLine();
                if ((act == "+") || (act == "/") || (act == "*") || (act == "-"))
                {

                    break;
                }
            }

            Console.WriteLine("Введите второе число");
            while (true)
            {
                string str1 = Console.ReadLine();
                bool res = int.TryParse(str1, out number);
                if (res == true)
                    break;
            }
            int b = number;

            int result = 0;
            switch (act)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            Console.WriteLine($"{a} {act} {b} = {result}");
            Console.WriteLine();
        }
        public string Description()
        {
            return "Задания лабораторной №2";
        }

        public int Id()
        {
            return 2;
        }

        public string Name()
        {
            return "Условия. Операторы сравнения";
        }
    }
}
