//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num3=Convert.ToInt32(Console.ReadLine());
if((num>num2)&&(num>num3))
{
     Console.WriteLine(num);
 }
 else if((num2>num)&&(num2>num3))
{
     Console.WriteLine(num2);
 }
 else if((num3>num)&&(num3>num2))
{
     Console.WriteLine(num3);
 }
