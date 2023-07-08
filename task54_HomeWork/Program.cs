// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] theMatrix = CreateAndFillMatrixByRandomInts(rowsQuantity, columnsQuantity, leftBorder: 0, rightBorder: 10);

PrintMatrix(theMatrix);

// Основная цель данного подхода - сокращение кол-ва итераций и минимаьная загрузка памяти.
// Method. Arranges values decreasing.
int[,] DecreaseMatrix(int[,] incomeMatrix)
{
    int[,] resultMatrix = new int[incomeMatrix.GetLength(0), incomeMatrix.GetLength(1)];
    resultMatrix = incomeMatrix;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1) - 1; j++)
        {
            if (resultMatrix[i, j] < resultMatrix[i, j + 1])
            {
                int temp = resultMatrix[i, j];
                resultMatrix[i, j] = resultMatrix[i, j + 1];
                resultMatrix[i, j + 1] = temp;
                for (int z = j; z > 0; z--)
                {
                    if (resultMatrix[i, z - 1] < resultMatrix[i, z])
                    {
                        int temp2 = resultMatrix[i, z - 1];
                        resultMatrix[i, z - 1] = resultMatrix[i, z];
                        resultMatrix[i, z] = temp2;
                    }
                    else break;
                }
            }
        }
    }
    return resultMatrix;
}

System.Console.WriteLine();
PrintMatrix(DecreaseMatrix(theMatrix));