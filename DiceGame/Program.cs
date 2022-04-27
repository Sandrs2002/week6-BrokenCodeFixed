using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Игра в кости
            //Компьюьер (cpu) и пользователь (user) играют в кости 
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто выбросил больший результат, то и победил в игре
            //бросок выполняется один раз
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userThrow - бросок пользователем; cpuScore - бросок компьютера;


            Console.WriteLine("Dice game! User vs computer");
            Console.WriteLine("To start press enter!");
            Console.ReadKey();

            Random rnd = new Random();

            int userThrow;
            int cpuThrow;
            int userScore = 0;
            int cpuScore = 0;

            
            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine("Computer rolls the dice");
                cpuThrow = rnd.Next(1, 7);

                Console.WriteLine("Computers score " + cpuThrow);

                Console.WriteLine("   ");

                userThrow = rnd.Next(1, 7);
                Console.WriteLine("Users turn. Press enter");
                Console.ReadKey();
                Console.WriteLine("Roll the dice");
                Console.WriteLine("Users score " + userThrow);
                Console.WriteLine("   ");


                if (userThrow > cpuThrow)
                {
                    userScore++;
                    Console.WriteLine("User wins");
                }
                else if (userThrow < cpuThrow)
                {
                    cpuScore++;
                    Console.WriteLine("Computer wins");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
            }


           

        }
    }
}
