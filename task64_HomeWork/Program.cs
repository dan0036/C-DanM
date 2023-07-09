// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Input a number: ");
int incomeNumber = Convert.ToInt32(System.Console.ReadLine());

void RowOfSubsequentNumbersDecreasingToOne(int n)
{
    if (n == 1)
    {
        System.Console.Write(1);
        System.Console.WriteLine();
        return;
    }
    System.Console.Write(n + ", ");
    RowOfSubsequentNumbersDecreasingToOne(n - 1);
}
RowOfSubsequentNumbersDecreasingToOne(incomeNumber);