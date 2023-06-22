// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
// в случайном порядке.[1,0,1,1,0,1,0,0]
s
// System.Console.Write("Input a number: ");
int[] twoDigArr = { 1, 0 };
int[] finalArr = new int[8];
for (int i = 0; i < 9; i++)
{
    finalArr[i] = new Random().Next(0, 2);
}
System.Console.WriteLine(finalArr);
