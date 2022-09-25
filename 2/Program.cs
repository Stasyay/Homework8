// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

int RealeseMatrix(int[,] matrix)
{
    int MinRowSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        MinRowSum = MinRowSum + matrix[0, i];
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int RowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            RowSum = RowSum + matrix[i, j];
        }
        if (MinRowSum > RowSum) MinRowSum = RowSum;
    }
    return MinRowSum;
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(RealeseMatrix(matrix));
