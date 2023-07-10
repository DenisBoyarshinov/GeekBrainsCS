// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 - 9

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(num));
int PrintNumbers(int num1)
{
    if (num1==0)
    {
    return 0;
    }
    return (num1 % 10 + PrintNumbers(num1 / 10));
}
