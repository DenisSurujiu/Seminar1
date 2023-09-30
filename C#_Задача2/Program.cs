using System;

namespace C__Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
//Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
int num = new Random().Next(10,1000);
Console.WriteLine(num);
if (num>99)
{
    Console.WriteLine(num=num%10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
        }
    }
}
