// (Задание 4) Программа которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке
//от (-N) до (N)
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int negNumber= -1*num;
while (negNumber<=num)
{
  Console.WriteLine(negNumber); 
  negNumber = negNumber+1;
}
