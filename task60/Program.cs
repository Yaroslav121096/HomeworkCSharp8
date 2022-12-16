void WriteArray (int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write( $"{matrix3D[i,j,k]}({j},{k},{i}) ");
      }
      Console.WriteLine();
    }

  }
}
void CreateArray(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.Clear();
Console.WriteLine("Задан трёхмерный массив размером 2 х 2 х 2: \n");
int[,,] matrix3D = new int[2, 2, 2];
CreateArray(matrix3D);
WriteArray(matrix3D);
