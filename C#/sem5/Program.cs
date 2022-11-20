// универсальные методы (почти)

int [] CreateRandArray(int ArrSize, int MinVal, int MaxVal){
    int [] array = new int[ArrSize];
    for(int i = 0; i < ArrSize; i++){
        array[i] = new Random().Next(MinVal,MaxVal + 1);
    }
    return array;
}

void ShowArray(int [] array){
    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + ", ");
        }
    Console.WriteLine("\b\b]");
}

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
/*

/*
int SumOfNegativeElements(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {if(array[i] < 0) sum += array[i];}
    return sum;
}

int size = 12;
int min = -9;
int max = 9;
int [] array = CreateRandArray(size,min,max);
ShowArray(array);
Console.WriteLine();
Console.WriteLine($"Sum of negative elements: {SumOfNegativeElements(array)}");
*/

// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
/*
int [] ConvertArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {array[i] *= -1;}
    return array;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandArray(size,min,max);

ShowArray(array);
Console.WriteLine();
Console.WriteLine("Converted:");
ConvertArray(array);
ShowArray(array);
*/
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
/*
bool FindNumber (int num,int [] array){
    int temp = 0;
    for(int i = 1; i < array.Length; i++){
        if(num == array[i]) temp++;}
    if(temp > 0) return true;
    return false;
} 

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandArray(size,min,max);
bool result = FindNumber(InputNum, array);

ShowArray(array);
Console.WriteLine();
Console.WriteLine($"NumFoundInd: {result}");
*/

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
/*
int GetNewArrSize(int OldArrSize){
    int NewArrSize = 0;
    if(OldArrSize % 2 == 0) NewArrSize = OldArrSize / 2;
    else NewArrSize = OldArrSize / 2 + 1;
    return NewArrSize;
}

int [] Multi (int [] old_array, int size){

    int old_ind = old_array.Length - 1;
    int [] new_array = new int[size];
    for(int i = 0; i < size ; i++)
    {   
        if(i == old_ind) 
        {
            new_array [i] = old_array [i];
        }
        else 
        {
            new_array [i] = old_array [i] * old_array [old_ind];
        }
        old_ind--;
    }
    return new_array;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int [] array_old = CreateRandArray(size,min,max);
ShowArray(array_old);
int size_new = GetNewArrSize(array_old.Length);
Console.WriteLine();
Console.WriteLine($"Old size: {array_old.Length}");
Console.WriteLine($"New size: {size_new}");
int [] array_new = Multi(array_old, size_new);
ShowArray(array_new);
*/

/*
ДЗ:
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.0 7.2 22.7 2.1 78.3] -> 76.2
*/

// Задача 34
/*
int CountEvenNums (int [] array){
    int qty = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) qty ++;
    }
    return qty;
}

Console.Write("Input array size: ");
int InputSize = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandArray(InputSize, 100, 999);
Console.WriteLine("Created random array:");
ShowArray(array);
int result = CountEvenNums(array);
Console.WriteLine($"Quantity of even numbers in array: {result}");
*/
// Задача 36
/*
int SumOddsPos(int [] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i += 2){
        sum += array[i];
    }
    return sum;
}

Console.Write("Input size: ");
int InputSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int InputMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int InputMax = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandArray(InputSize, InputMin, InputMax);
Console.WriteLine("Created random array:");
ShowArray(array);
int result = SumOddsPos(array);
Console.WriteLine($"Sum of numbers from odd positions in array: {result}");
*/
// Задача 38

double [] CreateRandDoubleArray(int ArrSize, int MinVal, int MaxVal){
    double [] array = new double[ArrSize];
    for(int i = 0; i < ArrSize; i++){
        array[i] = new Random().Next(MinVal,MaxVal + 1) + new Random().NextDouble();
    }
    return array;
}

void ShowDoubleArray(double [] array){
    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + "; ");
        }
    Console.WriteLine("\b\b]");
}

double MaxMinDiff(double [] array){
    int min_i = 0;
    int max_i = 0;
    for(int i = 1; i < array.Length; i++){
        if(array[i] < array[min_i]) min_i = i;
        if(array[i] > array[max_i]) max_i = i;
    }
    double diff = array[max_i] - array[min_i];
    return diff;
}

Console.Write("Input size: ");
int InputSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int InputMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int InputMax = Convert.ToInt32(Console.ReadLine());

double [] array = CreateRandDoubleArray(InputSize, InputMin, InputMax);
Console.WriteLine("Created random array:");
ShowDoubleArray(array);
double result = MaxMinDiff(array);
Console.WriteLine($"Difference of maximal and minimal numbers in array: {result}");