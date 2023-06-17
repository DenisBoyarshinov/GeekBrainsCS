// Задача 40: Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать треугольник
// со сторонами такой длины.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());

if ((a<b+c) && (b<a+c) && (c<b+a))
{
    Console.WriteLine("Может");
}
else
{
    Console.WriteLine("Числа не подходят");
}

