/* 
     Написать программу, которая в двумерном массиве заменяет строки на столбцы 
     или сообщить, что это невозможно (в случае, если матрица не квадратная). 
*/



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangedArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[i, j] = array[i, j];
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = arr[j, i];
            }
        }
    }
    else
    {
        Console.WriteLine("Невозможно заменить,матрица не квадратная: ");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество столбцов A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк B: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[A, B];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangedArray(array);
PrintArray(array);


