// 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int FindSumOfElementsOnTheMainDiagonalOfMatrix(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result += matrix[i,i];
    }
    return result;
}
System.Console.WriteLine();
System.Console.WriteLine(FindSumOfElementsOnTheMainDiagonalOfMatrix(theMatrix));