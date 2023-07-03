// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

System.Console.Write("Enter the quantity of rows: ");
int rowsQuantity = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Enter the quantity of columns: ");
int columnsQuantity = Convert.ToInt32(System.Console.ReadLine());

// Creating and filling with random int32s a matrix.
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

// Showing on console the matrix.
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

// Returns and prints arithmetical mean of the columns of the incomeing matrix.

double[] FindAverageOfColumnsOfMatrix(int[,] matrix)
{
    // Initiating integers of matrix lengthes to ease processor for the future calls.
    int quantityOfRows = matrix.GetLength(0);
    int quantityOfColumns = matrix.GetLength(1);

    double[] result = new double[quantityOfColumns];
    
    for (int j = 0; j < quantityOfColumns; j++)
    {
        double sumOfColumnElements = 0.0;
        for (int i = 0; i < quantityOfRows; i++)
        {
            sumOfColumnElements += matrix[i, j];
        }
        result[j] = Math.Round(sumOfColumnElements/quantityOfRows, 1);
        if (j<quantityOfColumns-1)
        {
            System.Console.Write(result[j]+"; ");
        }
        else
        {
            System.Console.Write(result[j]);
        }
    }
    return result;
}

FindAverageOfColumnsOfMatrix(theMatrix);