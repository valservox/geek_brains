/* ДЗ
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

y = k1 * x + b1, 
y = k2 * x + b2; 

значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/
// Задача 41: выдаёт количество положительных, меньшее на 1 от факта :(
/*
int [] CreateArray(int ArrSize){
    int [] array = new int[ArrSize];
    for(int i = 0; i < ArrSize; i++){
        Console.Write($"Array[{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int CountPositive(int [] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0){
//          Console.WriteLine($"{array[i]} is positive");    
            count++;
        };
        i++;
    }
    return count;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(size);
Console.WriteLine("Created array:");
ShowArray(array);

int qty = CountPositive(array);
Console.WriteLine($"Amount of positive nums in array: {qty}");
*/
// Задача 43
/*

y = k1 * x + b1, 
y = k2 * x + b2;

x = (b1-b2)/(k2-k1)
*/

double [] Cross(int b1, int b2, int k1, int k2){
    double [] array = new double[2];
    if(k1!=k2){
        array[0] = (b1 - b2)/(k2 - k1);
        array[1] = k1 * array[0] + b1;  
    }
    return array;
}

void ShowArray(double [] array){
    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + ", ");
        }
    Console.WriteLine("\b\b]");
}

Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double [] answer = Cross(b1, b2, k1, k2);

Console.Write("Cross point: ");
ShowArray(answer);