// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
int count = 0;
while (count < array.Length)
{
    array[count] = new Random().Next(0,9);
    Console.Write(array[count] + " ");
    count = count+1;
} 