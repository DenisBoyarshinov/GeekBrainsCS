// Напишите программу, которая на вход будет принимать
// два числа и выводить, является ли второе число кратным первомую
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Например:
// 34, 5 => не кратно, остаток 4
// 16, 4 => кратно

Console.WriteLine ("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
{
   Console.WriteLine ("Кратны"); 
}
else
{
    Console.WriteLine ("Остаток от деления"); 
    Console.WriteLine (num1 % num2);
}
