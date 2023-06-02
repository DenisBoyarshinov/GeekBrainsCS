// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
int num3 = num;
while(num != 0) 
{
    num1 = num % 10;      
    num2 = num2 * 10 + num1;
    num = num / 10;               
}
if (num3 == num2)
 {
    Console.WriteLine("Число является палиндромом");
} else {
    Console.WriteLine("Число не является палиндромом");
} 
