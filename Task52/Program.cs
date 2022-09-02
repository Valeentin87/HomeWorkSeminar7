// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("введите количество строк в массиве");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите количество колонок в массиве");
bool column = int.TryParse(Console.ReadLine(), out int n);

int[,] Array2D = FillArray2D(m, n);
double[] ResultSrArifm = SrArifmColumns(Array2D);
PrintArray2D(Array2D);
Console.WriteLine("среднее арифметическое каждого столбца:");
PrintResultArray(ResultSrArifm);


double[] SrArifmColumns(int[,] Array)
{
    double[] SrArifmColumn = new double[Array.GetLength(1)];
    double sum = 0.0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum = sum + Convert.ToDouble(Array[i, j]);

            if (i == Array.GetLength(0) - 1)
            {
                SrArifmColumn[j] = sum / Convert.ToDouble(Array.GetLength(0));
            }
        }
    }
    return SrArifmColumn;

}

int[,] FillArray2D(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
    return array;
}

void PrintResultArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]} ; ");
    }
}


void PrintArray2D(int[,] array)
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