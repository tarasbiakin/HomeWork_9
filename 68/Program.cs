﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите  число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numM, int numN)
{
    if( numM ==0) return numN+1;
    if( numM>0&&numN==0) return Akkerman(numM-1,1);
    return Akkerman(numM-1,Akkerman(numM,numN-1));
}
int akk= Akkerman(numberM,numberN);
Console.WriteLine($"{akk}");

