﻿// Задача 33: Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданое число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// 3; массив [6,7,19,345,3] -> да

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }    
}
void PrintArray(int[] col)
{
    int count =col.Length;
    int position = 0;
while (position < count)
{
    Console.WriteLine(col[position]);
    position++;
}
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
while (index < count)
{
    if (collection [index] == find)
    {
        position = index;
        break;
    }
    index++;
}    
return position;
}
int[] array = new int[10];
FillArray(array);
array[4] = 4;
array[8] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);