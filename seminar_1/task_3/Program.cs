// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите числом день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

{

if (number == 1)
    {
        Console.WriteLine("День недели - Понедельник");
    }
if (number == 2)
    {
        Console.WriteLine("День недели - Вторник");
    }
if (number == 3)
    {
        Console.WriteLine("День недели - Среда");
    }
if (number == 4)
    {
        Console.WriteLine("День недели - Четверг");
    }
if (number == 5)
    {
        Console.WriteLine("День недели - Пятница");
    }
if (number == 6)
    {
        Console.WriteLine("День недели - Суббота");
    }
if (number == 7)
    {
        Console.WriteLine("День недели - Воскресенье");
    }

if (number < 1 || number > 7) 
    {
        Console.WriteLine("В неделе 7 дней!!!))");
    }
}