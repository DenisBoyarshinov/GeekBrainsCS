// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите цифру");
int num = Convert.ToInt32(Console.ReadLine());
if (num==1)
{
    Console.WriteLine("Понедельник");
    Console.Write("Не является выходным днем");
}
else if (num==2)
{
    Console.WriteLine("Вторник");
    Console.Write("Не является выходным днем");
}   
else if (num==3)
{
    Console.WriteLine("Среда");
    Console.Write("Не является выходным днем");
}
else if (num==4)
{
    Console.WriteLine("Четверг");
    Console.Write("Не является выходным днем");
}
else if (num==5)
{
    Console.WriteLine("Пятница");
    Console.Write("Не является выходным днем");
}
else if (num==6)
{
    Console.WriteLine("Суббота");
    Console.Write("Является выходным днем");
}
else if (num==7)
{
    Console.WriteLine("Воскресенье");
    Console.Write("Является выходным днем");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}