﻿// Задача 35: Задайте одномерный массив 123
// случайных чисел. Найдите колличество эллементов
// массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
// В своем решении сделайте для 123
// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14] -> 5

void FillArray(int[]collection)
{
    int Length = collection.Length;
    int index = 0;
while (index < Length)
{
    collection[index] = new Random().Next(1, 201);
    index++;
}    
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
while (position < count)
{
    Console.WriteLine(col[position]);
    position++;
}    
}

int IndexOf(int[] collection)
{
    int num = 0;
    int count = collection.Length;
    int index = 0;
while (index < count)    
{
    if ((collection[index] > 9) && (collection[index] < 100))
    {
        num = num+1;
    }
    index++;
}
return num;
}
int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array);
Console.WriteLine(pos);
