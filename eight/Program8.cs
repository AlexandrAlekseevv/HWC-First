/*Задача 8:
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

using System;

Console.Write("Ведите число N : ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while(a<N+1)
{
    if(a %2 == 0)
    {
        Console.Write(a);
        a ++;
        if(a<N)//чтобы не записывалась последняя запятая
        {
            Console.Write(",");
        }
    }
    else
    {
        a ++;
    }
}
Console.WriteLine("");
