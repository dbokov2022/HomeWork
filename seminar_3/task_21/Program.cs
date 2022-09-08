// 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки A по Х:");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Y:");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Z:");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Х:");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Y:");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Z:");
int zB = Convert.ToInt32(Console.ReadLine());

double xD = xA - xB;
double yD = yA - yB;
double zD = zA - zB;

xD = Math.Pow(xD, 2);
yD = Math.Pow(yD, 2);
zD = Math.Pow(zD, 2);

double res = Math.Sqrt(xD + yD + zD);
Console.WriteLine($"{res:f2}");  // f2 - округление до 2 знаков после запятой