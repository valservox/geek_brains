// create string array

string [] CreateArray(string ArrSize){
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

string ModifiedArray(string [] InputArray){
    int NewArrSize = 0;
    for(int i = 0; i < InputArray.Length; i++){
        if(InputArray[i].Length <= 3) NewArrSize++;
    }
    string [] NewArray = new string[NeNewArrSize];
    int pos = 0;
    for(int i = 0; i < InputArray.Length; i++){
        if(InputArray[i].Length <= 3){
            NewArray[pos] = InputArray[i];
            pos++;
        }
    }
    return NewArray;
}