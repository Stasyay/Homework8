// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

void InputMatrix(int[,] matrix)
{
    int number = 1;
    int i = 1;
    int j = 1;
    for (int col = 0; col < matrix.GetLength(0); col++)
    {
        matrix[0, col] = number;
        number++;
    }

    for (int row = 1; row < matrix.GetLength(1); row++)
    {
        matrix[row, matrix.GetLength(1) - 1] = number;
        number++;
    }

    for (int col = matrix.GetLength(0) - 2; col >= 0; col--)
    {
        matrix[matrix.GetLength(0) - 1, col] = number;
        number++;
    }

    for (int row = matrix.GetLength(1) - 2; row > 0; row--)
    {
        matrix[row, 0] = number;
        number++;
    }

    while (number < matrix.GetLength(0) * matrix.GetLength(1))
    {
        while (matrix[i, j] == 0)
        {
            matrix[i, j] = number;
            number++;
            j++;
        }

        while (matrix[i + 1, j - 1] == 0)
        {
            matrix[i + 1, j - 1] = number;
            number++;
            i++;
        }

        while (matrix[i, j - 2] == 0)
        {
            matrix[i, j - 2] = number;
            number++;
            j--;
        }

        while (matrix[i - 1, j - 1] == 0)
        {
            matrix[i - 1, j - 1] = number;
            number++;
            i--;
        }
    }
    if (matrix[i, j] == 0) matrix[i, j] = number;
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


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

InputMatrix(matrix);
Console.WriteLine();

PrintMatrix(matrix);
