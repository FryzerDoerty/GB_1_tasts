// Напишите программу, которая на вход принимает число (N) , а на выходе показывает все чёные числа от 1, до N
Console.Write("Введите первое число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
if(N>=2){
while (i<=N)
{
    if (i%2==0){Console.Write(i);}
    i=i+2;
    
};}
else if(N<2){Console.Write(" ");}
Console.ReadKey();
