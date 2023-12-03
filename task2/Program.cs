// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



int[] GenerateArray(int size, int leftRange, int rightRange)
{
    // Внутри функции объявляем массив размером size. 
    int[] tempArray = new int[size];
    // Задаём объект класса Random для генерации случайных чисел. 
    Random rand = new Random();
    // Используем цикл for
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    // Вернуть значение массива
    return tempArray;
}

// Выводим вывод массива в отдельную функцию
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountDivBy7(int[] arr)
{
    int count = 0;
    for (int number = 0; number < arr.Length; number++)
    {
        if (arr[number] % 2 == 0)
        {
            count++;
        }
    }
    return count; 
}

// Объявим массив, который равен работе метода GenerateArray, внутрь метода мы отправим
// 1. размер генерируемого массива
// 2. левую границу генерации.
// 3. правую границу генерации. 
int[] myArray = GenerateArray(10, 100, 1000);
PrintArray(myArray);

// int count = 0;

// foreach ( int number in myArray)
//     if (number % 2 == 0)
//     {
//         count++;
//     }
// System.Console.Write($"Количество чётных числел в массиве: {count} ");


// РЕШЕНИЕ С ПОМОЩЬЮ ЦИКЛА FOR

// int count = 0;
// for (int number = 0; number < 10; number++)
// {
//     if (myArray[number] % 2 == 0)
//     {
//         count++;
//     }
// }
// System.Console.Write($"Количество чётных числел в массиве: {count} ");


// Вывод с помощью функции.
int countArr = CountDivBy7(myArray);
System.Console.Write($"Количетсво чётных чисел в массиве: {countArr} ");