void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void SortArrayLines(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void WriteArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int row = InputNumbers("Введите количество строк матрицы: ");
int col = InputNumbers("Введите количество столбцов: ");
int[,] matrix = new int[row, col];
InputMatrix(matrix);
Console.Clear();
Console.WriteLine($"Задана матрица размером: {row} на {col}: ");
Console.WriteLine($"\nИзначальный вид: ");
WriteArray(matrix);
Console.WriteLine($"\nСтроки отсортированы по убыванию: ");
SortArrayLines(matrix);
WriteArray(matrix);