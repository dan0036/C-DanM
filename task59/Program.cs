// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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


// Gets the number of row and the number of column of the minimum element.
int[] FindIndexesOfTheMinimumElementOfMatrix(int[,] matrix)
{
    int minimum = matrix[0, 0];
    int[] result = new int[2] { 0, 0 };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minimum)
            {
                minimum = matrix[i, j];
                result[0] = i; result[1] = j;
            }
        }
    }
    return result;
}

// Delets the row and the column with indexes of the minimum value elemet by creating 
// new matrix and moving rows and columns of the previous matrix left(2), up(3), and up&left(4), to the [0, 0] position.
// - - - - - | - - -
// - - 1 - - | - < 2
// - - - - - | - - -
// = = = = = + = = =
// - - ^ - - | \\  -
// - - 3 - - | - - 4

int[,] DeleteRowNColumnOfTheMinimumElement(int[,] matrix, int[] indexes)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    // Copies no-moving part (1).
    for (int i = 0; i < indexes[0]; i++)
    {
        for (int j = 0; j < indexes[1]; j++)
        {
            result[i, j] = matrix[i, j];
        }
    }
    // Moves part (2) to the left.
    for (int j = indexes[1]; j < result.GetLength(1); j++)
    {
        for (int i = 0; i < indexes[0]; i++)
        {
            result[i, j] = matrix[i, j + 1];
        }
    }
    // Moves part (3) up.
    for (int i = indexes[0]; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < indexes[1]; j++)
        {
            result[i, j] = matrix[i + 1, j];
        }
    }
    // Moves part (4) - up and left.
    for (int i = indexes[0]; i < result.GetLength(0); i++)
    {
        for (int j = indexes[1]; j < result.GetLength(1); j++)
        {
            result[i, j] = matrix[i + 1, j + 1];
        }
    }

    return result;
}

int[,] theMatrix = CreateAndFillMatrixByRandomInt(rowsQuantity, columnsQuantity);

// Creates int[] with coordinates of the minimum value element: 
// whrere [0] - row index, [1] - column index.
int[] foundIndexes = FindIndexesOfTheMinimumElementOfMatrix(theMatrix);

int[,] newMatrix = DeleteRowNColumnOfTheMinimumElement(theMatrix, foundIndexes);

PrintMatrix(theMatrix);

System.Console.WriteLine(
    "Coordinates of the minimum element: row " + foundIndexes[0] + ", column: " + foundIndexes[1]);

System.Console.WriteLine("Новый метод");
PrintMatrix(newMatrix);

System.Console.WriteLine("Семинарский метод");
PrintMatrix(DeleteMinColRow(theMatrix));


// ******************
// Метод, предложенный на семинаре.
int[,] DeleteMinColRow(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0, 0];
    int minCol = 0;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i < minRow && j < minCol)
            {
                newMatrix[i, j] = matrix[i, j];
            }
            else if (i < minRow && j >= minCol)
            {
                newMatrix[i, j] = matrix[i, j + 1];
            }
            else
            {
                newMatrix[i, j] = matrix[i + 1, j + 1];
            }
        }
    }
    return newMatrix;
}