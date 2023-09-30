using System;

namespace C__Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
//Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

int num = new Random().Next(1,8);
Console.WriteLine(num);
if(num=6 || num=7)
{
    Console.WriteLine("(этот день выходной) -> да");
}
else
{
    Console.WriteLine("(этот не выходной) -> нет");
}
        }
    }
}
