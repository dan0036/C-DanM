// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int[] ReturnIndexOfSearchingValueOfElement(int[,] matrix, int searchElement)
{
    int[] result = new int[2] { -1, -1 };
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == searchElement)
            {
                result[0] = i; result[1] = j;
                return result;
            }
        }
    }
    return result;
}

System.Console.Write("Enter a searching value of element: ");
int elementToFind = Convert.ToInt32(System.Console.ReadLine());

int[] indexOfFoundElement = ReturnIndexOfSearchingValueOfElement(theMatrix, elementToFind);

void PrintIndexOfFoundElement(int elementValue)
{
    if (indexOfFoundElement[0] == -1)
    {
        System.Console.WriteLine("There is no such a value.");
    }
    else
    {
        System.Console.WriteLine($"The indexes of first found searching value is: row {indexOfFoundElement[0]}, cloumn {indexOfFoundElement[1]}");
    }
}

PrintIndexOfFoundElement(elementToFind);

// Method returns quantity of found matches and coordinates of all of them.
// Метод способен, помимо печати координат, при необходимости, возвращать их значение в string[].

void ReturnQuantityOfMathesAndAllCoordinates(int[,] matrix, int searchElement)
{

    // Counts quantity of matches.
    int matches = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == searchElement)
            {
                matches++;
            }
        }
    }
    // Returns string[] with coordinates.

    string[] coordinates = new string[matches * 2];
    int coordinatesIndexCounter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == searchElement)
            {
                coordinates[coordinatesIndexCounter] = Convert.ToString(i);
                coordinates[coordinatesIndexCounter + 1] = Convert.ToString(j);
                coordinatesIndexCounter+=2;
            }
        }
    }


    // Prints the quantity of matches and all the coordinates;

    if (matches == 0)
    {
        System.Console.WriteLine("There is no such a value.");
    }
    else
    {
        System.Console.WriteLine("We found " + matches + " matches.");
        for (int i = 0; i < matches; i++)
        {
            System.Console.WriteLine($"The {i + 1} match indexes are: {coordinates[i * 2]}, {coordinates[i * 2 + 1]}");
        }
    }

}

ReturnQuantityOfMathesAndAllCoordinates(theMatrix, elementToFind);