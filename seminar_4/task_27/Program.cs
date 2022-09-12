// 27. Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSymmOfDigits(int n)
{
    int sym = 0;
    if (n < 0)
        n = n * -1;
        {
            while (n > 0)
            {
                sym = sym + n % 10;
                n = n / 10;
            }          
        }
    return sym;

}

int number = ReadNumber("Введите число:");
int sym = GetSymmOfDigits(number);
Console.WriteLine($"Cумма цифр в числе = {sym}");
