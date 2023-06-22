// Задача 49: Задайте двумерный массив. Найдите элеементы,
// у которых оба индекса четные, и замените эти эллементы на их квадраты.

// Например, изначально массив выглядел так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];

// Метод заполняет массив
void Array()
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(1,10);
    }
}
}
//Метод выводит массив
void PrintArray()
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
}  
 // Изменяет массив (находит эллемент с четными координатами и возводит в квадрат)
void ChangeArray()
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if ( (i%2 == 0) && (j%2 == 0))
        {
            matrix[i,j] = matrix [i,j] * matrix [i,j];
        }
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
}
Array();
PrintArray();
Console.WriteLine("_________________");
ChangeArray();
PrintArray();