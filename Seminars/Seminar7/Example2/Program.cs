// Задайте двумерный массив размера m на n,
// каждый эллемент в массивe находится по формуле Amn = m+n.
// Выведите полученный массив на экран.

// m = 3, n = 4.
// 0123
// 1234
// 2345

int rows = Convert.ToInt32(Console.ReadLine());
int colomns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,colomns];

void Array()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
    }
}

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
Console.WriteLine();
Array();
PrintArray();