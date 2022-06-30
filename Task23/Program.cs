﻿void Cube(int N)
{
    if (N < 0)
    {
        for (int i = -1; i >= N; i--)
        {
            int total = i * i * i;
            Console.Write(total + " ");
        }
    }
    else
    {
        for (int i = 1; i <= N; i++)
        {
            int total = i * i * i;
            Console.Write(total + " ");
        }
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов чисел от 1 до " + n + ": ");

Cube(n);
