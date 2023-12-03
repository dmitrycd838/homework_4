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

// Объявим массив, который равен работе метода GenerateArray, внутрь метода мы отправим
// 1. размер генерируемого массива
// 2. левую границу генерации.
// 3. правую границу генерации. 
int[] myArray = GenerateArray(10, 100, 1000); 
PrintArray(myArray);

int count = 0;

foreach ( int number in myArray)
    if (number % 2 == 0)
    {
        count++;
    }
System.Console.Write($"Количество чётных числел в массиве: {count} ");