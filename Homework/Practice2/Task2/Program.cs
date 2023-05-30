// Напишите прграмму, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 - 5
// 78 - третьей цифры нет
// 32679 - 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if ((num>99) && (num<1000))
{
int num1 = num%10;
Console.WriteLine(num1);
}
else if((num>999) && (num<10000))
{
int num2 = num%100;
int secondnum2 = num%10;
int result = (num2 * 10 + secondnum2)/100;
Console.WriteLine(result);
}
else if((num>9999) && (num<100000))
{
int num3 = num%1000;
int secondnum3 = num%10;
int result = (num3 * 10 + secondnum3)/1000;
Console.WriteLine(result);
}
else if (num>100001)
{
    Console.WriteLine("СЛИШКОМ БОЛЬШОЕ ЧИСЛО!");
}
