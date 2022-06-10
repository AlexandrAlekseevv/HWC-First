/*Задача 4: 
Напишите программу, которая принимает 
на вход три числа и выдаёт 
максимальное из этих чисел.
*/
using System;

Console.Write("Ведите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число : ");
int c = Convert.ToInt32(Console.ReadLine());
if((a != b)&(a != c)&(b != c)||
           ((a == b)&(a > c))||
           ((a == c)&(a > b))||
           ((b == c)&(b > a)))
{
    if((a>b)&(a>c)||
    ((a == b)&(a > c))||
    ((a == c)&(a > b)))
    {
        Console.WriteLine("Ответ :");
        Console.Write("Наибольшее число = ");
        Console.WriteLine(a);
        
    }

        if(((b>a)&(b>c))||
        ((b == c)&(b > a)))
    {
        Console.WriteLine("Ответ :");
        Console.Write("Наибольшее число = ");
        Console.WriteLine(b);
    }
    if((c>a)&(c>b))
    {
        Console.WriteLine("Ответ :");
        Console.Write("Наибольшее число = ");
        Console.WriteLine(c);

    }
}
else
{
    Console.Write("Ой!");
    Console.WriteLine("Введёные числа равны");
}

