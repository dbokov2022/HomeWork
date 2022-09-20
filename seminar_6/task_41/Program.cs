// // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// // Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// // Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целое число (для остановки введите 'stop')");

int i = 0;
bool flag = true;   

while (flag == true) 
{    
    string n = Console.ReadLine();

    if (n != "stop" ) 
        {        
            int r = Convert.ToInt32(n) ;      
            if (r > 0)
                {
                    i++;
                }     
            
        }
    else if (n == "stop")
        {
            flag = false;
            break;
        }

}

Console.WriteLine("\nРезультат:\nКоличество чисел больше нуля = " + i);
