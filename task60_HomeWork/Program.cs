// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Method. Creates and fills with random integers within -9to9(optional) the matrix 
// with asked quantity of rows and columns and sheets.
int[,,] CreateAndFillMatrixByRandomInts(uint rows, uint columns, uint sheets, int leftBorder, int rightBorder)
{
    Random rnd = new Random();
    int[,,] result = new int[rows, columns, sheets];
    for (int k = 0; k < sheets; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j, k] = rnd.Next(leftBorder, rightBorder);
            }
        }
    }
    return result;
}

// Prints the incoming matrix.
void PrintMatrix(int[,,] incomeMatrix)
{
    for (int k = 0; k < incomeMatrix.GetLength(2); k++)
    {
        for (int i = 0; i < incomeMatrix.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < incomeMatrix.GetLength(1); j++)
            {
                if (incomeMatrix[i, j, k] >= 0)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write(" " + incomeMatrix[i, j, k]);

            }
        }
        System.Console.WriteLine();
    }
}

// Asks quantity of rows and columns for a new matrix.
System.Console.Write("Enter quantity of rows: ");
uint rowsQuantity = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of columns: ");
uint columnsQuantity = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of sheets: ");
uint sheetsQuantity = Convert.ToUInt32(System.Console.ReadLine());

int[,,] theMatrix = CreateAndFillMatrixByRandomInts(rowsQuantity, columnsQuantity, sheetsQuantity, leftBorder: 0, rightBorder: 10);

PrintMatrix(theMatrix);
System.Console.WriteLine();

// Method. Prints value and indexes of all matrix elements.
void PrintMatrixAndIndexes(int[,,] incomeMatrix)
{
    for (int k = 0; k < incomeMatrix.GetLength(2); k++)
    {
        for (int i = 0; i < incomeMatrix.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < incomeMatrix.GetLength(1); j++)
            {
                if (incomeMatrix[i, j, k] >= 0)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write($" {incomeMatrix[i, j, k]}({i},{j},{k})");

            }
        }
        System.Console.WriteLine();
    }
}

PrintMatrixAndIndexes(theMatrix);