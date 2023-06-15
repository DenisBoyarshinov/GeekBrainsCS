// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int[] array = new int[5];
int max = 0;
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);

    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

int result = max - min;

Console.WriteLine("Рандомный массив: " + String.Join(", ", array));
Console.WriteLine("Разница между максимальным и минимальным элементами: " + result);