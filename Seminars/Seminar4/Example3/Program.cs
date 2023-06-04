//Напишите программу, которая принимает на вход
//  число и выдает количество цифр в числе. 
//                                                  
//  Пример:                                         
//      456 -> 3                                    
//       78 -> 2                                    
//    89126 -> 5                                    

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int GetNumLength()
// {
//     return Convert.ToString(number).Length;
// }
// Console.WriteLine(GetNumLength());


int GetNumLength2()
{
    int i = 0;
    while (number != 0) 
    {
        number /= 10;
        i++; 
    }
    return i;
}
Console.WriteLine(GetNumLength2());