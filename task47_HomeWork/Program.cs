// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.Write("Enter the quantity of rows: ");
int rowsQuantity = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Enter the quantity of columns: ");
int columnsQuantity = Convert.ToInt32(System.Console.ReadLine());

// Creating and filling with random doubles a matrix.
double[,] CreateAndFillMatrixByRandomDouble(int row, int column)
{
    double[,] newMatrix = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i, j] = Math.Round(rnd.NextDouble() * 20 - 10, 2);
        }
    }
    return newMatrix;
}

// Showing on console the matrix.
void PrintMatrixDouble(double[,] matrix)
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

PrintMatrixDouble(CreateAndFillMatrixByRandomDouble(rowsQuantity, columnsQuantity));
