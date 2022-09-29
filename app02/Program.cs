// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

// int GetSumPositive(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             sum += arr[i];
//         }
//     }
//     return sum;
// }
// int GetSumNegative(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0)
//         {
//             sum += arr[i];
//         }
//     }
//     return sum;
// }

// int[] GetSums(int[] arr)
// {
//     int[] sumArray = new int[2];
//     sumArray[0] = 0;
//     sumArray[0] = 0;

    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             sumArray[0] += arr[i];
//         }
//         if (arr[i] < 0)
//         {
//             sumArray[1] += arr[i];
//         }
//     }
//     return sumArray;
// }


int[] array = new int[12];

FillArray(array);
PrintArray(array);

// Console.WriteLine("Сумма положительных: " + GetSumPositive(array));
// Console.WriteLine("Сумма отрицательных: " + GetSumNegative(array));


// int[]OutMassiv = new int[2];
// OutMassiv = GetSums(array);
//  Console.WriteLine("Сумма положительных: " + OutMassiv[0]);
//  Console.WriteLine("Сумма отрицательных: " + OutMassiv[1]);

 int LimitedArraySum(int[] array, bool direction, int limit)
{
    int sum=0;
    if (direction==true)
    {
        for(int i=0; i<array.Length; i++)
        {
            if (array[i]>limit)
            {
                sum+=array[i];
            }
        }
    }
    else
    {
        for(int i=0; i<array.Length; i++)
        {
            if (array[i]<limit)
            {
                sum+=array[i];
            }
        }
    }
    return sum;
}

Console.WriteLine("Сумма положительных: "+LimitedArraySum(array,true,0));
Console.WriteLine("Сумма отрицательных: "+LimitedArraySum(array,false,0));
