// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int ImputNumber()
{
    Console.WriteLine("Введите число 1:");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
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

int[] array = new int[20];

int a = ImputNumber();

void SearchNumber(int[] arr,int arg)
{

    int search = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == a)
        {
            search = 1;
        }
    }
    if(search==1)
    {
        Console.WriteLine("Есть совпадения.");
    }
    else
    {
        Console.WriteLine("Совпадений нет.");
    }
}

FillArray(array);
PrintArray(array);

SearchNumber(array,a);