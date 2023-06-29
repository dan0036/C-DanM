// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Enter the quantity of numbers u wonna check: ");
int m = Convert.ToInt32(System.Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    System.Console.Write("Enter a number: ");
    int num = Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine();
    if (num>0)
    {
        count++;
    }

}
System.Console.WriteLine(count);