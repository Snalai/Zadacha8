﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
int y = i % 2;
    if (y == 0)
    {
        Console.WriteLine(i);    
    }
    
i++;
}






