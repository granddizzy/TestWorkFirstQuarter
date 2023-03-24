using System;

/// <summary>
/// Класс отвечающий за обрабку массива
/// </summary>
public static class ArrayHandler
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="size"></param>
    /// <returns>Пустой массив строк</returns>
    public static string[] CreateEmptyArray(int size)
    {
        return new string[size];
    }

    /// <summary>
    /// Метод заполнения массива пользователем
    /// </summary>
    /// <value>Заполненный пользователем массив</value>
    public static string[] FillArray(this string [] arr)
    {
        for (int i=0; i<arr.Length; i++)
        {
            string text=String.Empty;

            while (string.IsNullOrEmpty(text))
            {
                Console.Write($"Input a string number {i+1}: ");
                text = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(text))
                    Console.Write("String is empty!!! ");
            }
            
            arr[i] = text;
        }
        return arr;
    }


    
}