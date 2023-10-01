int[,] matrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

int minSumRow = FindRowWithMinSum(matrix);

Console.WriteLine("Наменьшая сумма элементов: " + (minSumRow + 1));

static int FindRowWithMinSum(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minSumRow = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRow = i;
        }
    }

    return minSumRow;
}
