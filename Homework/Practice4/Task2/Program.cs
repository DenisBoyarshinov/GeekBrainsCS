// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int num)
 {
    int sum = 0;
    string numLength = Convert.ToString(num);
    for (int i = 0; i < numLength.Length; i++)
     {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

Console.Write(SumOfNumbers(num));