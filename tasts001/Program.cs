// Напишите программу, которая на вход принимает два числа и выдает какое из них большее, а какое меньшее 
Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB) {Console.Write(numberA + ">" +numberB + ", max =" + numberA);}
else{Console.Write(numberA + "<" +numberB + ", max =" + numberB);}
Console.ReadKey();