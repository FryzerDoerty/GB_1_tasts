// See https://aka.ms/new-console-template for more information
//a = 
Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB) {Console.Write(numberA + ">" +numberB);}
else{Console.Write(numberA + "<" +numberB);}
Console.ReadKey();