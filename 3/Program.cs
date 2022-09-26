// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

void RealeseMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixResult = new int[matrixFirst.GetLength(0), matrixFirst.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            matrixResult[i, j] = matrixFirst[i, j] * matrixSecond[i, j];

            Console.Write(matrixResult[i, j] + " \t");
            
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixFirst = new int[n, m];
int[,] matrixSecond = new int[n, m];
InputMatrix(matrixFirst);
Console.WriteLine();
Console.WriteLine("Первая матрица");
PrintMatrix(matrixFirst);
InputMatrix(matrixSecond);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintMatrix(matrixSecond);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
RealeseMatrix(matrixFirst, matrixSecond);

