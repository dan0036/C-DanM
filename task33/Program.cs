// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

System.Console.Write("Input a number of array elements: ");
Start:
bool checkStrToInt = int.TryParse(Console.ReadLine(), out int n);
if (checkStrToInt != true || n <= 0)
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

System.Console.Write("Input the lookingfor element: ");
StartTwo:
bool checkStrToIntTwo = int.TryParse(Console.ReadLine(), out int searchElement);
if (checkStrToIntTwo != true)
{
    System.Console.Write("Input a correct element: ");
    goto StartTwo;
}

SearchingMethod(anyArray);

void SearchingMethod(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] == searchElement)
        {
            System.Console.WriteLine($"The number {searchElement} is present in the array.");
            break;

        }
        else
        {
            i++;
            if (i == arr.Length)
            {
                System.Console.WriteLine($"The number {searchElement} is NOT present in the array.");
            }
        }
    }

}
