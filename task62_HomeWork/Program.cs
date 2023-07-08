// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Method. Creates and fills matrix with subsequent decreasing numbers, starting from 0.
int[,] CreateAndFillMatrixLikeMaryGoRound(int rows, int columns)
{

    int[,] result = new int[rows, columns];
    int filler = 0;
    void Filling(int rowStart, int rowFinish, int colStart, int colFinish)
    {
        for (int j = colStart; j < colFinish; j++) // from top left to right.
        {
            result[rowStart, j] = filler;
            if (filler == rows * columns-1)
            {
                return;
            }
            filler++;
        }
        for (int i = rowStart + 1; i < rowFinish; i++) // from top right to bottom.
        {
            result[i, colFinish - 1] = filler;
            if (filler == rows * columns-1)
            {
                return;
            }
            filler++;
        }
        for (int jj = colFinish - 2; jj >= colStart; jj--) // from bottom right to left.
        {
            result[rowFinish - 1, jj] = filler;
            if (filler == rows * columns-1)
            {
                return;
            }
            filler++;
        }

        for (int ii = rowFinish - 2; ii > rowStart; ii--) // from bottom left to top.
        {
            result[ii, colStart] = filler;
            if (filler == rows * columns-1)
            {
                return;
            }
            filler++;
        }

        Filling(rowStart + 1, rowFinish - 1, colStart + 1, colFinish - 1);
    }
    Filling(0, rows, 0, columns);
    return result;
}

// Prints the incoming matrix.
void PrintMatrix(int[,] incomeMatrix)
{
    for (int i = 0; i < incomeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < incomeMatrix.GetLength(1); j++)
        {
            if (incomeMatrix[i, j] < 10)
            {
                System.Console.Write(" ");
            }
            System.Console.Write(" " + incomeMatrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

// Asks quantity of rows and columns for a new matrix.
System.Console.Write("Enter quantity of rows: ");
int rowsQuantity = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of columns: ");
int columnsQuantity = Convert.ToInt32(System.Console.ReadLine());

int[,] theMatrix = CreateAndFillMatrixLikeMaryGoRound(rowsQuantity, columnsQuantity);

PrintMatrix(theMatrix);
System.Console.WriteLine();