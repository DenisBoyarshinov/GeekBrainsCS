﻿// Напишите программу, которая принимает на вход
// число (A) и выдает сумму чисел от 1 до A.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int GetSumNumber()
{
    int sum = 0;
    int count =1;

    while (count<=num)
    {
        sum = sum + count;
        count = count + 1;
    }    
    return sum;

}
int result = GetSumNumber();
Console.WriteLine(result);