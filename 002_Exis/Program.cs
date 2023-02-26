Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == numA * numA)
Console.WriteLine("Второе число квадрат первого");
else if (numA == numB * numB)
Console.WriteLine("Первое число квадрат второго");
else 
Console.WriteLine("Числа не являются квадратами друг друга");

