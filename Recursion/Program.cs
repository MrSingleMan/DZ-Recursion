// Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void FromMToN(int m, int n)
// {
//     if (m > n)
//     {
//         FromMToN(n-1, m);
//         Console.Write(m + ", ");
//     }
//     else if (n > m)
//     {
//         FromMToN(m, n-1);
//         Console.Write(n + ", ");
//     }
//     else Console.Write(m + ", ");
// }
// FromMToN(10,5);


//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
// }
// Console.WriteLine(Akkerman(3,3));

//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int[] Mass = { 1, 2, 5, 10, 12, 9 };

void PrintMass(int[] Mass, int i)
{
    if (i < Mass.Length)
    {
        Console.Write($"{Mass[Mass.Length - i - 1]} ");
        PrintMass(Mass, i + 1);
    }
}

PrintMass(Mass, 0);