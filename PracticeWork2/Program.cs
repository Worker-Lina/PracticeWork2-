using System;

namespace PracticeWork2
{
    class Program
    {
        static void Main(string[] args)
        {

            //№1
            /*Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * x - 3 * x + 4;
            Console.WriteLine($"y = {y}");*/

            //№2
            /*Console.WriteLine("Введите радиус окружности: ");
            double circleRadius = double.Parse(Console.ReadLine());
            double circlSquare = 3.14 * circleRadius * circleRadius;
            double circleLength = 2 * 3.14 * circleRadius;
            Console.WriteLine($"площадь круга = {circlSquare}, длина окружности =  {circleLength}");*/


            //№3
            /*Console.WriteLine("Введите расстояние в сантиметрах: ");
            int centimeters = int.Parse(Console.ReadLine());
            int meter = centimeters / 100;
            Console.WriteLine($"количество полных метров: {meter}");*/


            //№4
            /*int dayAmount = 234;
            double weeksAmount = dayAmount/7;
            Console.WriteLine($"Количество полных недель:  {weeksAmount}");*/


            //№5
            /*Console.WriteLine("Введите двузначное число");
            int Num1 = int.Parse((Console.ReadLine())); 
            Console.WriteLine("Число десяток в нем = {0}", Num1 / 10); 
            Console.WriteLine("Число единиц в нем = {0}", Num1 % 10);
            Console.WriteLine("Сумма его цифр = {0}", Num1 % 10 + Num1 / 10);
            Console.WriteLine("Произведение его цифр = {0}", (Num1 % 10) * (Num1 / 10));*/


            //№6	
            /*Console.WriteLine("Введите четырехзначное число: ");
            int someNumber = int.Parse(Console.ReadLine());
            int NumbersSum = (someNumber / 1000) + (someNumber / 100 % 10) + (someNumber / 10 % 10) + someNumber % 10;
            Console.WriteLine($"сумма цифр в {someNumber} = {NumbersSum}");
            double NumbersProiz = (someNumber / 1000) * (someNumber / 100 % 10) * (someNumber / 10 % 10) * (someNumber % 10);
            Console.WriteLine($"произведение цифр в {someNumber} = {NumbersProiz}");*/


            //№7
            /*int firstNumber = 456 / 100;
            int secondNumber = 456 % 10;
            int thirdNumber = 456 / 10 % 10;
            int x = int.Parse(firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString());
            Console.WriteLine($"число х = {x}");*/


            //№8
            bool X = true;
            bool Y = true;
            bool firstResult = !X & !Y;
            bool secondResult = X | (!Y & !X);
            bool thirdResult = (!X & !Y) | Y;
            Console.WriteLine($"x = {X}, y = {Y}");
            Console.WriteLine($"1) {firstResult}, 2) {secondResult}, 3) {thirdResult}");



        }
    }
}


