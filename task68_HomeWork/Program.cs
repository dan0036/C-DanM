// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


System.Console.Write("Input a positive number m: ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Input a positive number n: ");
int n = Convert.ToInt32(System.Console.ReadLine());

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        // System.Console.Write("."); //Shows the quantity of function selfcalls.
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
        
    }
    else return -1;
}

System.Console.WriteLine(AckermanFunction(m, n));