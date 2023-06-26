// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
    anyArray[i] = rnd.Next(0, 200);
}
System.Console.WriteLine($"[{String.Join(", ", anyArray)}]");

// We initated and filled the array named anyArray.

int CounterTenToNinetyNine(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        count += 1;
    }
    return count;
}

System.Console.Write("The quantity of elements between 10 and 99 is: ");
System.Console.WriteLine(CounterTenToNinetyNine(anyArray));