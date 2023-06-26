// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] newOppositeCouplesMultiplierArr(int[] arr)
{
    int len = arr.Length;
    int newLen = (int)Math.Ceiling((double)len / 2);
    int[] newArr = new int[newLen];
    //System.Console.WriteLine(len); // Shows the length of the new array.
    if (len % 2 == 1) //fills new array in case the old one has odd quantity oe elem-s.
    {
        for (int i = 0; i < newLen - 1; i++)
        {
            newArr[i] = arr[i] * arr[len - i-1];
        }
        newArr[newLen - 1] = arr[newLen - 1];
        return newArr;
    }
    else //fills new array in case the old one has even quantity of elem-s.
    {
        for (int i = 0; i < newLen; i++)
        {
            newArr[i] = arr[i] * arr[len - i-1];
        }
        return newArr;
    }

}


System.Console.WriteLine($"[{String.Join(", ", newOppositeCouplesMultiplierArr(anyArray))}]");