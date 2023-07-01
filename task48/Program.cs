// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4

System.Console.Write("Enter the quantity of rows: ");
int rowsQuantity = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Enter the quantity of columns: ");
int columnsQuantity = Convert.ToInt32(System.Console.ReadLine());

int[,] CreateAndFillMatrixBySumOfIndexesOfMatrixInt(int row, int column)
{
    int[,] newMatrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i, j] = i + j;
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j]+" ");
        }
        System.Console.WriteLine();
    }
}

// int[,] TheMatrix = CreateAndFillMatrixByRandomInt(rowsQuantity, columnsQuantity);
// PrintMatrix(TheMatrix);
// System.Console.WriteLine();

PrintMatrix(CreateAndFillMatrixBySumOfIndexesOfMatrixInt(rowsQuantity, columnsQuantity));