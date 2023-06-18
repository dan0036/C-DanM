//  Напишите программу, которая принимает на вход координаты двух точек 
//  и находит расстояние между ними в 2D пространстве.

System.Console.Write("Input xOne and yOne: ");
double xOne = Convert.ToDouble(Console.ReadLine());
double yOne = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Input xTwo and yTwo: ");
double xTwo = Convert.ToDouble(Console.ReadLine());
double yTwo = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(xOne-xTwo, 2) + Math.Pow( yOne-yTwo, 2)), 2));