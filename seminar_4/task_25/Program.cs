// 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


double GetPow(int N,  int p)
{
    int i = 0;
    double res = 1;
    
    if (p == 0)
        {         
            res = 1;     // любое число в степени 0 = 1
        } 
    
    if (p > 0)
        {
            while (i < p)
            {
                res = res * N;
                i++;
            }   
    
        }

    if (p < 0)
        {
            while (i > p)
                {
                    res = res / N;
                    i = i - 1;
                }  
        
        }

    return res;    
}

int A = ReadNumber("Введите число A:");
int B = ReadNumber("Введите степень B:");

double r = GetPow(A, B);
Console.WriteLine($"Результат = {r}");

