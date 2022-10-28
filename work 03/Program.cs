// В прямоугольной матрице найти строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
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
int A = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество строк B: ");
int B = int.Parse(Console.ReadLine()?? "0");

int[,] arr = new int[A, B];
FillArray(arr);
PrintArray(arr);
int line = 0;
int result = 100;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];        
    }
    if (sum < result)
    {
        result = sum;
        line++;
    }
}

Console.WriteLine("Наименьшая строка №: " + (line) + "  Сумма строки = " + (result));

