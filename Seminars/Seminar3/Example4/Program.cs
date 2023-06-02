// Напишите программу, которая принимает на вход
// число (N) и выдает таблицу квадратов чисел
// от 1 до N.
// * 5 -> 1,4,9,16,25.
// * 2 -> 1,4

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(num>=count)
{
    Console.WriteLine(Math.Pow(count,2));
    count = count + 1;
}