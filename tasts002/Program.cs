// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB && numberA>numberC) {Console.Write("max=" + numberA);}
else if (numberB>numberA && numberB>numberC) {Console.Write("max=" + numberB);}
else if (numberC>numberA && numberC>numberB) {Console.Write("max=" + numberC);}
Console.ReadKey();
