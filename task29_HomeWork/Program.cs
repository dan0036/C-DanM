// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] newArr  = new int [8];
Random rnd = new Random(); 

for (int i = 0; i < 8; i++)
{
    newArr[i] = rnd.Next(0,100);
}

System.Console.WriteLine($"[{String.Join(", ", newArr)}]");