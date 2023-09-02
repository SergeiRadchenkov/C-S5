/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-9, 10);
    }
}

bool FindNum(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
            return true;
    }
    return false;
}


void PrintArray(int[] newArray)
{
    Console.Write("[ ");
    for (int i = 0; i < newArray.Length -1; i++)
        Console.Write(newArray[i] + ", ");
    Console.Write(newArray[newArray.Length -1] + " ]");
    Console.WriteLine();
}
int size = InputNum("Введите размер массива: ");
int[] newArray = new int [size];
FillArray(newArray);
// PrintArray(newArray);
int num = InputNum("Введите число: ");
PrintArray(newArray);
bool answer = FindNum(newArray, num);
// if (answer) 
//     Console.WriteLine("Данное число есть в массиве");
// else 
//     Console.WriteLine("Данного числа нет в массиве");

Console.WriteLine(answer == true?"Да, данное число есть в массиве.":"Нет, данного числа нет в массиве.");