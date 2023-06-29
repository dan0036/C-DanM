// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.Write("Input a number: ");
int n = Convert.ToInt32(System.Console.ReadLine());

int[] arrFib = new int[n];
arrFib[0] = 0;
arrFib[1] = 1;
for (int i = 2; i < n; i++)
{
    arrFib[i] = arrFib[i-2] + arrFib[i-1];
}
System.Console.WriteLine(string.Join(", ", arrFib));