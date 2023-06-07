
int[,] matrix = new int [3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr [i, j]} ");
        }
        Console.WriteLine();
}
}
void FillArray(int[,] matr) 
{
   for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(1,10);
    }
}
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
