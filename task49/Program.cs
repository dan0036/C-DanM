// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

System.Console.Write("Enter the quantity of rows: ");
int rowsQuantity = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Enter the quantity of columns: ");
int columnsQuantity = Convert.ToInt32(System.Console.ReadLine());

int[,] CreateAndFillMatrixByRandomInt(int row, int column)
{
    int[,] newMatrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i, j] = rnd.Next(0, 10);
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
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] theMatrix = CreateAndFillMatrixByRandomInt(rowsQuantity, columnsQuantity);
PrintMatrix(theMatrix);

int[,] ChangeMatrixByDoublingElmentsWithBothEvenIndexes(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i,j];
        }
    }
    return matrix;
}

System.Console.WriteLine();
PrintMatrix(ChangeMatrixByDoublingElmentsWithBothEvenIndexes(theMatrix));
