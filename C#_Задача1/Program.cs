using System;

namespace C__Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
//Задача 10: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num1 = num/100;
int num2 = num %10;
int result = (num/10%10);
Console.WriteLine(result);
        }
    }
}
