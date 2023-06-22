// Задача 46: Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.

// m = 3, n = 4
// 1 4 8 1 9
// 5 -2 33 -2
// 77 3 8 1

int rows = Convert.ToInt32(Console.ReadLine());
int colomns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,colomns];


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
Array();
PrintArray();
    