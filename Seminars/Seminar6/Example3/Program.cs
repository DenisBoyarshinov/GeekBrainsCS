// Задача 44: Не испоьзуя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи:
// 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int firstnum = 0;
int secondnum = 1;
Console.Write(firstnum + " " + secondnum + " ");


for (int i = 3; i <= num; i++)
{
    int newNum = firstnum + secondnum;
    Console.Write(newNum + " ");

    firstnum = secondnum;
    secondnum = newNum;
}