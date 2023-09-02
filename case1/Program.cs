/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

/* void FillArray(int[] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(minValue, maxValue +1);
} */

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(-9, 10);
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length -1; i++)
        Console.Write(arr[i] + ", ");
    Console.Write(arr[arr.Length -1] + " ]");
    Console.WriteLine();
}

void SumPosNegElements(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumPos += arr[i];
        else 
            sumNeg += arr[i];
    }
    Console.WriteLine($"Сумма положительных элементов равна {sumPos}");
    Console.WriteLine($"Сумма отрицательных элементов равна {sumNeg}");
}

int size = InputNum("Введите размер массива: ");
// int min = InputNum("Введите минимальное значение элемента:");
// int max = InputNum("Введите максимальное значение элемента:");

int[] myArray = CreateArray(size);
// FillArray(myArray, min, max);
FillArray(myArray);

PrintArray(myArray);
SumPosNegElements(myArray);