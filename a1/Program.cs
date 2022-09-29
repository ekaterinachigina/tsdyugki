// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"


Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int cons = N;
Output( cons, 1);
void Output (int num, int constanta)
{
    if (num == 1 ) return;
    if (num%2==0)
    Console.Write($"{num}, ");
    Output(num-1, constanta);
}