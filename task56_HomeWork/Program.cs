// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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

// Prints the incoming matrix.
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

// Asks quantity of rows and columns for a new matrix.
System.Console.Write("Enter quantity of rows: ");
uint rowsQuantity = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of columns: ");
uint columnsQuantity = Convert.ToUInt32(System.Console.ReadLine());

int[,] theMatrix = CreateAndFillMatrixByRandomInts(rowsQuantity, columnsQuantity, leftBorder: -9, rightBorder: 10);

PrintMatrix(theMatrix);
System.Console.WriteLine();

int GetsRowWithMaxSumOfElements(int[,] matrix)
{
    int maxSum = 0;
    int rowMax = 0;

    //Finds sum of the 0 row. Needed if we work with negative numbers. 
    for (int j = 0; j < theMatrix.GetLength(1); j++)
    {
        maxSum += matrix[0, j];
    }

    for (int i = 1; i < theMatrix.GetLength(0); i++)
    {
        int sum = matrix[i, 0];
        for (int j = 1; j < theMatrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum > maxSum)
        {
            maxSum = sum;
            rowMax = i;
        }
    }
    return rowMax;
}

System.Console.WriteLine($"The biggest row is # {GetsRowWithMaxSumOfElements(theMatrix)}");