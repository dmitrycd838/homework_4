// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)


int[] myArray = { 14, 5, 13, 23 };


for (int i = myArray.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine(myArray[i]);
}

System.Console.WriteLine("Вывод массива: ");