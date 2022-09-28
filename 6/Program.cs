// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника


Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }

    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1)-1; j++)
            matrix[i, j] = matrix[i - 1, j] + matrix[i - 1, j - 1];
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] triangle = new int[n, n];

InputMatrix (triangle);
PrintMatrix(triangle);

