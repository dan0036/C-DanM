// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Input a smaller positive number: ");
uint startNumber = Convert.ToUInt32(System.Console.ReadLine());
System.Console.Write("Input a bigger positive number: ");
uint finishNumber = Convert.ToUInt32(System.Console.ReadLine());

uint SumOfSubsequentUIntsBetweenNumbers(uint start, uint finish)
{
    uint result = (finish * finish + finish - (start - 1) * (start - 1) - start + 1) / 2;
    return result;
}

System.Console.WriteLine(SumOfSubsequentUIntsBetweenNumbers(startNumber, finishNumber));