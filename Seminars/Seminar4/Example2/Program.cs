﻿// Напишите программу, котрая выводит массив из 8 эллементов,
// заполненный нулями и еденицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void CreateArray()
{
    int[] arr = new int[8];
    int count = 0;
    while(count < arr.Length)
    {
        arr[count] = new Random().Next(0,2);
        Console.Write(arr[count] + " ");
        count++;
    }
}
CreateArray();
