﻿//Вид

// void Method1()
// {
//     Console.WriteLine("Автор Денис");
// }
//Method1();


//Вид2
// void Method2(string msg)
// {   
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");



// void Method21(string msg,int count)
// {   
//     int i = 0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст",count: 4);


//Вид3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


//Вид4

string Method4(int count, string text)
{
    int i =0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10,"qwerty"+" ");
Console.WriteLine(res);