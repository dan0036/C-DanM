// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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

int[] DiffBtwnMinMaxElmnts (int[] arr)
{
    int[] result = {arr[0], arr[0], 0};

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<result[0])
        {
            result[0] = arr[i];
        }
        else if (arr[i]>result[1])
        {
            result[1] = arr[i];
        }
    }
result[2] = result[1] - result[0];
return result; 
}
System.Console.WriteLine($"{String.Join(" -> ", DiffBtwnMinMaxElmnts(anyArray))}");