/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int FindNum(int[] newArray){
            int count = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if(newArray[i] >= 10 && newArray[i] <= 99){
                    count ++;
                }
            }
            return count;
        }

        void FillArray(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = new Random().Next(0, 201);
            }
        }

    int[] newArray = new int [123];
    FillArray(newArray);
    int res = FindNum(newArray);
    System.Console.WriteLine(res);