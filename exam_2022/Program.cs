﻿// create string array

string [] CreateArray(int ArrSize){
    string [] array = new string[ArrSize];
    for(int i = 0; i < ArrSize; i++){
        Console.Write($"Array[{i}]: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// show array

void ShowArray(string [] array){
    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + ", ");
        }
    Console.WriteLine("\b\b]");
}

// Create new array from original with specified elements

string [] ModifyArray(string [] InputArray){
    int NewArrSize = 0;
    for(int i = 0; i < InputArray.Length; i++){
        if(InputArray[i].Length <= 3) NewArrSize++;
    }
    string [] NewArray = new string[NewArrSize];
    int j = 0;
    for(int i = 0; i < InputArray.Length; i++){
        if(InputArray[i].Length <= 3){
            NewArray[j] = InputArray[i];
            j++;
        }
    }
    return NewArray;
}


Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

string [] InputArray = CreateArray(size);
Console.WriteLine("Created array:");
ShowArray(InputArray);

Console.WriteLine("Modified array:");
string [] ModifiedArray = ModifyArray(InputArray);
ShowArray(ModifiedArray);