﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int B = Convert.ToInt32(Console.ReadLine());

// double d = Math.Pow(A,B);
// Console.WriteLine(d);

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

int NumberPower(int a, int b)
 {
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }

    return result;
}

Console.WriteLine(NumberPower(num1, num2));