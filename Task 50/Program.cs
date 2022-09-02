// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.


Console.WriteLine("введите количество строк в массиве");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("введите количество колонок в массиве");
bool column = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("введите число, которое будем искать в массиве");
int number = Convert.ToInt32(Console.ReadLine());
int[,] Matrix2D = FillArray2D(m, n);
PrintArray2D(Matrix2D);
int[] IndexesAndQuantityCount = SearchElement(Matrix2D, number);
if (IndexesAndQuantityCount[2] == 0)
{
    Console.WriteLine($"искомый элемент в массиве отсутствует");
}
else
{
    Console.WriteLine($"искомый элемент находится на позиции ({IndexesAndQuantityCount[0]} , {IndexesAndQuantityCount[1]}) и повторяется {IndexesAndQuantityCount[2]} раз");
}

int[] SearchElement(int[,] Array, int searchMeaning)
{
    int[] Indexes = new int[3] { 0, 0, 0 };

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] == searchMeaning)
            {
                Indexes[0] = i;
                Indexes[1] = j;
                Indexes[2]++;
            }
        }
    }
    return Indexes;

}
int[,] FillArray2D(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0 , 11);
        }
    }
    return array;
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