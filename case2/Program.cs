/* Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int InputNum(string message){
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArray){
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-9, 10);
    }
}

void Trade(int[] newArray){
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] *= -1;
    }
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
PrintArray(newArray);
Trade(newArray);
PrintArray(newArray);