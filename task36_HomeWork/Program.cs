// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

// Initializing and filling the array named anyArray.
Begining:
System.Console.Write("Input a number of array elements: ");
int dummCheck = 0;
Start:
bool checkStrToInt = int.TryParse(Console.ReadLine(), out int n);
if (checkStrToInt != true || n <= 0)
{
    System.Console.Write("Input a correct positive integer: ");
    dummCheck += 1;
    if (dummCheck > 3)
    {
        System.Console.WriteLine("Please, try another time. Take a rest.");
        goto Begining;
    }
    else
    {
        goto Start;
    }
}
int[] anyArray = new int[n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    anyArray[i] = rnd.Next(0, 10);
}
System.Console.WriteLine($"[{String.Join(", ", anyArray)}]");

// We initiated and filled the array named anyArray. 

int SumOfOddElemets (int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        result += arr[i];
    }
    return result;
}
System.Console.WriteLine($"The sum of odd elements is: {SumOfOddElemets(anyArray)}");