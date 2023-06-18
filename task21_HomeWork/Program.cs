// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Input x, y and z coordinates for the first dot: ");
double xOne = Convert.ToDouble(Console.ReadLine());
double yOne = Convert.ToDouble(Console.ReadLine());
double zOne = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Input x, y and z coordinates for the second dot: ");
double xTwo = Convert.ToDouble(Console.ReadLine());
double yTwo = Convert.ToDouble(Console.ReadLine());
double zTwo = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("The result is: " + Math.Round(Math.Sqrt
(Math.Pow(xOne - xTwo, 2) +
Math.Pow(yOne - yTwo, 2) +
Math.Pow(zOne - zTwo, 2)
), 2));