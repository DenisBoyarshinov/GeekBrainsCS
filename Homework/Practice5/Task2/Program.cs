// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int [5];
int count = 0;
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
        arr[i] = new Random().Next(1, 100);
        Console.WriteLine(arr[i]);
        count++;
}
Console.WriteLine();

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j]%2!=0)
    {
        sum += arr[j];
        count++;
    }
}
Console.WriteLine(sum);