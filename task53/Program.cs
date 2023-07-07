// Задача 53: 
// Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.

System.Console.Write("Enter quantity of rows: ");
uint rowsQuantity = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of columns: ");
uint columnsQuantity = Convert.ToUInt32(System.Console.ReadLine());

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

// Method. Swaps 1st and last rows.
int[,] SwapsRowsFirstAndLast(int[,] incomeMatrix)
{
    int[,] result = incomeMatrix;
    int rowsLength = incomeMatrix.GetLength(0);
    int columnsLength = incomeMatrix.GetLength(1);
for (int j = 0; j < columnsLength; j++)
{
    int temporary = incomeMatrix[0,j];
    incomeMatrix[0,j] = result[rowsLength-1,j];
    result[rowsLength-1,j] = temporary;
}
return result;
}

System.Console.WriteLine();
PrintMatrix(SwapsRowsFirstAndLast(theMatrix));

