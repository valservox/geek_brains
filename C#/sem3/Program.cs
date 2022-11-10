/*
  ДЗ
    Задача 19

    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет
    12821 -> да
    23432 -> да

    Задача 21

    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53

    Задача 23
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

// Задача 19
/*
void NumberCheck(int num)
{
    int part_1 = num % 100;
    int part_2 = num / 1000;

    if(num >= 10000 && num < 100000)
    {
        if(part_1 % 10 == part_2 / 10 && part_1 / 10 == part_2 % 10) Console.WriteLine($"Number {num} is palindrome");
        else Console.WriteLine($"Number {num} is not palindrome");
    }
    else Console.WriteLine($"Number {num} is not 5-decimal");
}

Console.Write("Input number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
NumberCheck(InputNum);
*/
// Задача 21



// Задача 23

void GetThirdPowerList (int num)
{
    for(int i = 1; i <= num; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}

Console.Write("Input number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"{InputNum}: ");
GetThirdPowerList(InputNum);