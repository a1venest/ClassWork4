// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9, 10);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] array = new int[20];

// FillArray(array);
// PrintArray(array);
// int MinesPlus(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }
    

// }
    
// Console.WriteLine(MinesPlus(array));


void FillArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max+1);
    }
}

string StringArray(int[] array, string split)
{
    int lenght=array.Length;
    string textarray=String.Empty;
    for (int i = 0; i < lenght; i++)
    {
        textarray+=array[i];
        if(i<lenght-1)
        {
            textarray+=split;
        }
    }
    return textarray;
}

void ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}


int[] massiv = new int[20];
FillArray(massiv, -9,9);
Console.WriteLine("Массив: " + StringArray(massiv, ", ") + " ");

ChangeArray(massiv);
Console.WriteLine("Массив: " + StringArray(massiv, ", ") + " ");
