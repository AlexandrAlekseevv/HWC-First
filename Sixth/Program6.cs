/* Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/
using System;

Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

if(a %2 == 0)
{
    Console.WriteLine("Ваше число чётное !");
}
else
{
    Console.WriteLine("Ваше число нечётное !");
}