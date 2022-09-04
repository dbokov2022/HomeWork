// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите числом день недели, для проверки выходной ли: ");
int number = Convert.ToInt32(Console.ReadLine());{

if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, это выходной день");
    }
else if (number < 1 || number > 7) 
    {
        Console.WriteLine("В неделе всего 7 дней :-) ");
    }
else 
    {
        Console.WriteLine("Нет, это не выходной день");
    }
}