// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько нужно чисел?");
int count = Convert.ToInt32(Console.ReadLine());
int pos = 0;

Console.WriteLine("Введите числа");
while (count > 0)
{
    int enter = Convert.ToInt32(Console.ReadLine());
    if (enter > 0)
    {
        pos++;
    }
    count--;
}
Console.WriteLine();
Console.Write("Колличество чисел больше нуля"+ " " + pos);