/*
int FindBiggestDigit(int number)
{
    int ed = number % 10; // единицы
    int dec = number / 10; // десятки

    if (ed > dec) return ed;
    else return dec;
}
int randNum = new Random().Next(10, 100);
int result = FindBiggestDigit(randNum);

Console.WriteLine($"The biggest digit of {randNum} is {result}");
*/
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int DeleteSecondDigit(int number)
{
    int digit_1 = number / 100; 
    int digit_3 = number % 10;
    int result = digit_1 * 10 + digit_3;
    return result;
}
int randNum = new Random().Next(100, 1000);
int newNum = DeleteSecondDigit(randNum);

Console.WriteLine($"Result of convertation {randNum} is {newNum}");
*/
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
/*
void GetRemainder(int num1, int num2)
{
    int remainder = num2 % num1;
    if(remainder == 0){
        Console.WriteLine($"{num1} is multiple of {num2}");
    }
    else{
        Console.WriteLine($"remainder after division: {remainder}");
    }
}

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

GetRemainder(num1, num2);
*/
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b
/*
void CheckNumbers(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 & num1 % num3 == 0)
    {
        Console.WriteLine($"{num1} is multiple of {num2} and {num3}");
    }
    else
    {
        Console.WriteLine($"{num1} is not multiple of {num2} and {num3}");
    }
}

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number : ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input one more number : ");
int num3 = Convert.ToInt32(Console.ReadLine());

CheckNumbers(num1, num2, num3);
*/
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool CheckNumbers(int num1, int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1) return true;
    return false;
}

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumbers(num1, num2);
Console.WriteLine($"{result}");
*/
/*
 ДЗ:
 Решить при помощи методов. НЕ ИСПОЛЬЗОВАТЬ МАССИВЫ И СТРОКИ
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    456 -> 5
    782 -> 8
    918 -> 1

    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    645 -> 5

    78 -> третьей цифры нет

    32679 -> 6

    Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    6 -> да
    7 -> да
    1 -> нет
*/

// Задача 10
/*
int GetThirdDigit(int num)
{
    int digit_23 = num % 100;
    int result = digit_23 / 10;
    return result;
}

Console.Write("Input number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());

int digit_2 = GetThirdDigit(InputNum);
Console.WriteLine($"{digit_2}");
*/
// Задача 13
/*
void GetThirdDigitIfExists(int num)
{
    while (num > 999) num /= 10;
    if(num < 100)
    {
        Console.Write("Третьей цифры нет");
        return;
    }
    int result = num % 10;
    Console.WriteLine($"{result}");
}

Console.Write("Введите число: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
GetThirdDigitIfExists(InputNum);
*/
// Задача 15
/*
bool IsWeekend(int num)
{
    if(6 == num || num == 7) return true;
    return false;
}

Console.Write("Введите число: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{IsWeekend(InputNum)}");
*/