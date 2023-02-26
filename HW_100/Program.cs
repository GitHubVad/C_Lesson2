// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист",
//  для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста,
//   5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно 
// обработает все случаи, как минимум до 1000 человек.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
string tov = "программистов";
string st = "программист";
string sta = "программиста";
int num1 = 0;
int temp = num / 10;
int temp1 = temp % 10;
num1 = num % 10;
if (temp1 == 1 && num1 == 1)
  Console.Write($"{num} {tov}");
else 
if (num1 == 1)
    Console.Write($"{num}  {st}"); 
    else 
        if (num1 >= 5 && num1 <= 9) 
        Console.Write($"{num} {tov}");
        else 
        if (temp1 == 1) 
             Console.Write($"{num} {tov}");
                else 
                     if (num1 >= 2 && num1 <= 4)
                    Console.Write($"{num} {sta}");
                        else Console.Write($"{num} {tov}");

