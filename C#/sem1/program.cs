// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
/*
//Ввод -> Возведение в квадрат -> Вывод
Console.Write("Input int number: ");

int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Power of {num} is {result}");
*/

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2){
    Console.WriteLine($"{num1} is power of {num2}");
}
else{
    Console.WriteLine($"{num1} is not power of {num2}");
}
*/
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = (-1) * num;
while(current <= num ){
    Console.WriteLine(current + " ");
    current++;
}
*/
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three-digit int number : ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 3;

Console.WriteLine($"Last digit of {num} is {result}");
*/
/* 
 ДЗ:
    Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3

    Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22

    Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    4 -> да
    -3 -> нет
    7 -> нет

    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    5 -> 2, 4
    8 -> 2, 4, 6, 8
*/

// Задача 2
/*
Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"{num1} is greater than {num2}");
}
if(num1 < num2){
    Console.WriteLine($"{num1} is fewer than {num2}");
}
else{
    Console.WriteLine($"{num1} and {num2} are equal");
}
*/
// Задача 4
/*
Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number : ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input one more number : ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(max < num2){
    max = num2;
}
if(max < num3){
    max = num3;
}
Console.WriteLine($"{max} is maximum number");
*/
// Задача 6
/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool rem = num % 2 == 0;
if(rem){
    Console.Write($"{num} is even");
}
else{
    Console.Write($"{num} is not even");
}
*/
// Задача 8

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool rem;
int i = 1;
if(num <= i){
    Console.Write("Error");
    Environment.Exit(0);
}
Console.Write($"Even numbers between 1 and {num} are: ");
while(i <= num){
    rem = i % 2 == 0;
    if(rem){
        Console.Write(i + " ");
    }
    i++;
}