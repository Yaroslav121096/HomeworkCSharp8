void ResultMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            result = firstMartrix[i, j] * secomdMartrix[i, j];
            resultMatrix[i, j] = result;
        }
    }
}
void CreateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите количество строк матриц: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матриц: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[,] firstMartrix = new int[row, col];
CreateMatrix(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[row, col];
CreateMatrix(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[row, col];

ResultMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц: ");
WriteArray(resultMatrix);