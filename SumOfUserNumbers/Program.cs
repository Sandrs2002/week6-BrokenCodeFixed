using System;

namespace SumOfUserNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Сумма трех чисел
            //приложение предлагает пользователю ввести три числа и выводит на экран их сумму
            //исправленный до рабочего состояния код дает до 5 пунктов 

            Console.WriteLine("Enter three number and get the sum");
            Console.WriteLine("  ");

            int sum = 0;

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("   ");
            }


            Console.WriteLine($"Total: {firstNumber + secondNumber + thirdNumber}");
        }
    }
}
