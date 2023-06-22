// Задача 51: Задайте двумерный массив. Найдите сумму
// эллементов находящихся на главной диагонали (с индексами (0,0); (1,1) и так далее.
// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма эллементов главной диагонали 1+9+2=12

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];

// Метод заполняет массив
void FillingArray()
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
 // Находим эллемент с координатами (0,0) (1,1)  и так далее
void SearchEllementOfArray()
{ 
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if ((i == j))
        {
            sum = sum + matrix[i,j];
        }
    }
 }
 Console.WriteLine($"Сумма равна: {sum} ");
}
FillingArray();
PrintArray();
SearchEllementOfArray();