// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1,2,3,4,5"
// M = 4; N = 8 -> "4,5,6,7,8"

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(num, number));

string PrintNum(int num1, int num2)
{
    if(num1>num2)
    {
        Console.WriteLine("Не подходит");
        return "Не подходит";
    }
    if(num1==num2)
    {
        return num1.ToString();
    }
    return(num1 + " " + PrintNum(num1+1,num2));
}