
void PascalTriangle(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0)
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}
void Paskal(double[,] pascal)
{
    for (int k = 0; k < pascal.GetLength(0); k++)
    {
        pascal[k, 0] = 1;
    }
    for (int i = 1; i < pascal.GetLength(0); i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            pascal[i, j] = pascal[i - 1, j] + pascal[i - 1, j - 1];
        }
    }
}
void WriteArray(double[,] pascal)
{
    for (int i = 0; i < pascal.GetLength(0); i++)
    {
        for (int j = 0; j < pascal.GetLength(1); j++)
        {
            if (pascal[i, j] != 0)
            {
                Console.Write($"{pascal[i, j]} ");
            }
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Первые {n} строк треугольника Паскаля: \n");
double[,] pascal = new double[n + 1, 2 * n + 1];
Paskal(pascal);
PascalTriangle(pascal);
Console.WriteLine();
WriteArray(pascal);