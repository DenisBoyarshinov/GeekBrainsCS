// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причем X не равен нулю
// и Y не равен нулю. И выдает номер четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите число");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int Y = Convert.ToInt32(Console.ReadLine());

if ((X>0) && (Y>0))
{
    Console.WriteLine("Первая четверть");
}
else if ((X<0) && (Y>0))
{
    Console.WriteLine("Вторая четверть");
}
else if ((X<0) && (Y<0))
{
    Console.WriteLine("Третья четверть");
}
else
{
    Console.WriteLine("Четвертая четверть");
}