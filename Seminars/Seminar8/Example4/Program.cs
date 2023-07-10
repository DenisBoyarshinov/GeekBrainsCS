// Задача 69: Напишите программу, котрая на вход принимает два числа
// А и В и возводит число А в целую степень В с помощью ркурсии.

// A = 3; B = 5 -> 243 (3 в степени 5)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int Multiplication(int number1, int number2)
{
    if (number2 == 0)
    {
        return 1;
    }
    if (number2 == 1)
    {
        return number1;
    }
    return (number1 * Multiplication(number1,number2 -1));
}   
Console.WriteLine(Multiplication(num, num1));