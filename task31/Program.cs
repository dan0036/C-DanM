// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

System.Console.Write("Input a number of array elements: ");
Start:
bool checkStrToInt = int.TryParse(Console.ReadLine(), out int n);
if (checkStrToInt != true || n<=0)
{
    System.Console.Write("Input a correct positive integer: ");
    goto Start;
}
int[] anyArray = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    anyArray[i] = rnd.Next(-9, 10);
}
System.Console.WriteLine($"[{String.Join(", ", anyArray)}]");
void PosOrNegSum(int[] arr)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            pos += arr[i];
        }
        else if (arr[i] < 0)
        {
            neg += arr[i];
        }
    }
    System.Console.WriteLine($"The sum of positive elements is: {pos}");
    System.Console.WriteLine($"The sum of negative elements is: {neg}");
}

PosOrNegSum(anyArray);