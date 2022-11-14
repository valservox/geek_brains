/*
ДЗ: Решить задачи, используя МЕТОДЫ
Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

3, 5 -> 243 (3⁵)
0, 0 - >1
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

// 25
/*
int Power(int num1, int num2){
    int result = 0;
    if(num2 == 0) result = 1;
    else{
        result = num1;
        for(int i = 1; i < num2; i++) result *= num1;
    }
    return result;
}

Console.Write("Input number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input power: ");
int InputPow = Convert.ToInt32(Console.ReadLine());

if(InputPow >= 0){
    int result = Power(InputNum,InputPow);
    Console.WriteLine($"{InputNum} ^ {InputPow} = {result}");
}
else{
    Console.WriteLine("ERROR: power must be natural");
}
*/

// 27
/*
int DigitSum (int num){
    if(num < 0) num *= -1;
    int temp = num / 10;
    int result = num % 10;
    while(temp > 0){
        result += temp % 10;
        temp /= 10;
    }
    return result;
}

Console.Write("Input number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());

int result = DigitSum(InputNum);
Console.WriteLine($"DigitSum of {InputNum} is {result}");
*/

// 29

int [] CreateRandArray(int ArrSize, int MinVal, int MaxVal)
{
    int [] array = new int[ArrSize];
    for(int i = 0; i < ArrSize; i++)
    {
        array[i] = new Random().Next(MinVal,MaxVal + 1);
    }
    return array;
}

void ShowArray(int [] array)
{   int i = 0;
    Console.Write("[" + array[i] + ", ");
    for(i = 1; i < array.Length; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b]");
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 99;

int [] array = CreateRandArray(size, min, max);
ShowArray(array);