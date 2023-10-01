int[,] matrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] rowArray = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowArray[j] = matrix[i, j];
    }
    System.Array.Sort(rowArray, (a, b) => -a.CompareTo(b));
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rowArray[j];
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i, j] + " ");
    }
    System.Console.WriteLine();
}
