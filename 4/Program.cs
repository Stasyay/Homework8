// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Clear();

void InputMatrix(int[,,] matrix)
{
    int[] tmp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    for (int i = 0; i < tmp.Length; i++)
    {
        tmp[i] = new Random().Next(10, 100);
        
        for (int j = 0; j < i; j++)
        {
            while (tmp[i] == tmp[j])
            {
                tmp[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }

    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = tmp[count];
                count++;
            }
        }
    }
 }

void RealeseMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) \t");
        }
    }
}


// Console.Write("Введите первое значение: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе значение: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье значение: ");
// int z = Convert.ToInt32(Console.ReadLine());
int[, ,] matrix = new int[2, 2, 2];
InputMatrix(matrix);
Console.WriteLine();
RealeseMatrix(matrix);
