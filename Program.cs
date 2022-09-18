// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.Write("Enter number m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > n)
// {

// }
// else
// {
//     PrintNumber1(m, n);
// }
// void PrintNumber1(int m, int n1)
// {
//     if (n1 < m) return;
//     PrintNumber1(m, n1 - 1);
//     Console.Write(n1 + " ");
// }


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int m = InputNumbers("Enter m: ");
// int n = InputNumbers("Enter n: ");
// int temp = m;

// if (m > n)
// {
//     m = n;
//     n = temp;
// }

// PrintSumm(m, n, temp = 0);

// void PrintSumm(int m, int n, int summ)
// {
//     summ = summ + n;
//     if (n <= m)
//     {
//         Console.Write($"Sum of elements = {summ} ");
//         return;
//     }
//     PrintSumm(m, n - 1, summ);
// }
// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }



// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// Например:
// m = 2, n = 3 -> A(m,n) = 9


int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Ackermann function = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

