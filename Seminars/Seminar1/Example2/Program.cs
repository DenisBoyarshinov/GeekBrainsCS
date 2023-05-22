// (ЗАДАНИЕ2) Программа которая на вход принемает два числа, проверяет является ли первое число квадратом второго

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2=Convert.ToInt32(Console.ReadLine());
if(num==num2*num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет"); 
}
