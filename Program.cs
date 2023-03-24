using static ArrayHandler;

int size=-1;
while (size<=0)
{
    Console.Write("Input array size value above zero: ");

    size = Convert.ToInt32(Console.ReadLine());
    if (size<=0)
        Console.Write("Invalid array size!!! ");
}

int maxStringSize=-1;
while (maxStringSize<=0)
{
    Console.Write("Input maximum string size value above zero: ");
    
    maxStringSize = Convert.ToInt32(Console.ReadLine());
    if (maxStringSize<=0)
        Console.Write("Invalid maximum string size!!! ");
}

string[] arr = CreateEmptyArray(size).FillArray();

Console.WriteLine("Begin array:");
arr.ShowArray();

string[] newArr = arr.CreateArrayByParameters(maxStringSize);
Console.WriteLine("Array of strings satisfying the condition: The length of the string is less than :" + maxStringSize);
newArr.ShowArray();