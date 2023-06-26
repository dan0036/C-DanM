// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    anyArray[i] = rnd.Next(100, 1000);
}
System.Console.WriteLine($"[{String.Join(", ", anyArray)}]");

// We initiated and filled the array named anyArray. 

int Counter(int[] arr)
{
    int quantityEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            quantityEven++;
        }
    }
    return quantityEven;
}

System.Console.WriteLine($"The quantity of even elements of the array is: {Counter(anyArray)}.");
