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

    /// <summary>
    /// Метод вывода массива
    /// </summary>
    /// <param name="arr"></param>
    public static void ShowArray(this string[] arr)
    {
        Console.Write("[");

        for (int i=0; i<arr.Length; i++)
            Console.Write((i>0 ? ",\"" :"\"") + arr[i] + "\"");

        Console.WriteLine("]");
    }

    /// <summary>
    /// Метод создает массив из arr с элементами, где длина строки меньше либо равна заданной maxStringSize.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="maxStringSize"></param>
    /// <returns>Новый массив</returns>
    public static string[] CreateArrayByParameters(this string[] arr, int maxStringSize)
    {
        string[] newArr = new string[arr.Length];
    
        int realSize=0;
        for (int i=0; i<arr.Length; i++)
            if (arr[i].Length<=maxStringSize)
            {
                newArr[realSize]=arr[i];
                realSize++;
            } 

        if (realSize<arr.Length)
            Array.Resize(ref newArr, realSize);   

        return newArr;
    }

}