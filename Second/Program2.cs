/*Задача 2:
 Напишите программу, которая на 
вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
*/
using System;

Console.WriteLine("Ведите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
if(b>a)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else{
    if(a == b)
    {
       Console.Write("оба значения равны ");
       Console.WriteLine( b);
}
    }


