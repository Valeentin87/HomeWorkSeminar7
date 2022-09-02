// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[] Matrix = IsNumbers();//введенные с помощью метода данные будем вкладывать в одномерный массив из двух элементов
double[,] DoubleArray2D = FillArray2D(Matrix[0], Matrix[1]);
PrintArray2D(DoubleArray2D);
int[] IsNumbers()
{
    int[] array = new int[2];
    bool rows = true;
    bool columns = true;
    do
    {
        
        Console.WriteLine("Введите количество строк");
        rows = int.TryParse(Console.ReadLine(), out int m);
        Console.WriteLine("Введите количество столбцов");
        columns = int.TryParse(Console.ReadLine(), out int n);
        array[0] = m;
        array[1] = n;
    }
    while ((rows == false) || (columns == false));
    Console.WriteLine("корректный ввод");
    return array;
}

double[,] FillArray2D(int rows, int columns)
{
    Random random = new Random();
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble(),1);
        }
    }
    return array;
}
void PrintArray2D(double[,] array)
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

