// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 0)
{
Console.WriteLine("Число не положительное или ноль!!!");
}
else
{
int b = 2;
while(b <= a)
{
    Console.Write(b + " ");
    b = b + 2;
}
}