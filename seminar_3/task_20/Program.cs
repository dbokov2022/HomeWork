// 20: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату точки A по Х:");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Y:");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Х:");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Y:");
int yB = Convert.ToInt32(Console.ReadLine());


double res =  Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
Console.WriteLine($"{res:f3}");  // f3 - округление до 3 знаков после запятой