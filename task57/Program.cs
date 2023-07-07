// Составить частотный словарь (сколько раз встречается) жлементов матрицы.

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

// Asks quantity of rows and columns for a new matrix.
System.Console.Write("Enter quantity of rows: ");
uint rowsQuantity = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Enter quantity of columns: ");
uint columnsQuantity = Convert.ToUInt32(System.Console.ReadLine());

int[,] theMatrix = CreateAndFillMatrixByRandomInts(rowsQuantity, columnsQuantity, leftBorder: 0, rightBorder: 10);

PrintMatrix(theMatrix);

// Method. Returns array in which on even positions (from 0) is value of element of incomeing matrix 
// and quantity of times it meets in the matrix on the next, odd, (from 1) position of array.   
int[] DictionaryOfQuantityOfMatrixElements(int[,] incomeMatrix)
{
    int[] dictionaryOfQuantity = new int[2 * incomeMatrix.GetLength(0) * incomeMatrix.GetLength(1)];
    int ii = 0;
    int[,] newMatrix = incomeMatrix;
    for (int i = 0; i < incomeMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < incomeMatrix.GetLength(1); j++)
        {
            bool chekIfUnmet = true;
            for (int n = 0; n < ii; n += 2) // The first element will always pass this FOR check.
            {
                if (dictionaryOfQuantity[n] == newMatrix[i, j])
                {
                    chekIfUnmet = false;
                }
            }
            if (chekIfUnmet == true)
            {
                dictionaryOfQuantity[ii] = newMatrix[i, j];
                int count = 0;
                for (int z = 0; z < newMatrix.GetLength(0); z++)
                {
                    for (int y = 0; y < newMatrix.GetLength(1); y++)
                    {
                        if (dictionaryOfQuantity[ii] == newMatrix[z, y])
                        {
                            count++;
                        }
                    }
                }
                dictionaryOfQuantity[ii + 1] = count;
                ii += 2;
            }
        }
    }

    // Пришлось создавать два массива, т. к. не проходили других типов коллекций, 
    // а массивы имеют неизменяемую длину.
    int[] dictionaryOfQuantityFinalLength = new int[ii]; 
    for (int i = 0; i < ii; i++)
    {
        dictionaryOfQuantityFinalLength[i] = dictionaryOfQuantity[i];
    }
    return dictionaryOfQuantityFinalLength;
}

// Method. Prints <Dictionary Of Quantity Of Met Elements Of Matrix>.
void PrintDictionaryOfQuantityOfMatrixElements(int[] dictionary)
{
    for (int i = 0; i < dictionary.Length - 1; i += 2)
    {
        System.Console.WriteLine($"The element {dictionary[i]} is met {dictionary[i + 1]} times.");
    }
}

System.Console.WriteLine();
PrintDictionaryOfQuantityOfMatrixElements(DictionaryOfQuantityOfMatrixElements(theMatrix));

