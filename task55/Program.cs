// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

// Asks quantity of rows and columns for a new matrix.
System.Console.Write("Enter quantity of rows: ");
uint rowsQuantity = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of columns: ");
uint columnsQuantity = Convert.ToUInt32(System.Console.ReadLine());

// Method. Creates and fills with random integers within -9to9(optional) the matrix 
// with asked quantity of rows and columns.
int[,] CreateAndFillMatrixByRandomInts(uint rows, uint columns, int leftBorder, int rightBorder)
{
    Random rnd = new Random();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(leftBorder, rightBorder);
        }
    }
    return result;
}

// Prints the incomeing matrix.
void PrintMatrix(int[,] incomeMatrix)
{
    for (int i = 0; i < incomeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < incomeMatrix.GetLength(1); j++)
        {
            if (incomeMatrix[i, j] >= 0)
            {
                System.Console.Write(" ");
            }
            System.Console.Write(" " + incomeMatrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

int[,] theMatrix = CreateAndFillMatrixByRandomInts(rowsQuantity, columnsQuantity, leftBorder: -9, rightBorder: 10);

PrintMatrix(theMatrix);

// Method. Swaps rows and columns. Returns new matrix.
int[,] SwapsRowsNColumns(int[,] incomeMatrix)
{
    int[,] resultMatrix = new int[incomeMatrix.GetLength(1), incomeMatrix.GetLength(0)];
    for (int i = 0; i < incomeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < incomeMatrix.GetLength(1); j++)
        {
            resultMatrix[j, i] = incomeMatrix [i,j];
        }
    }
    return resultMatrix;
}

System.Console.WriteLine();
PrintMatrix(SwapsRowsNColumns(theMatrix));