// Задача 32. Напишите программу замена эллементов массива:
// положительные эллементы замените на соответствующие отрицательные,
// и наоборот. [-4,-8,8,2] -> [4,8,-8,-2]

int [] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-8,9);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
    Console.Write(array[i] + " ");
}