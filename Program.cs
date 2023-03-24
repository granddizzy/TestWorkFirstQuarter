
using static ArrayHandler;

int size=-1;
while (size<0)
{
    Console.Write("Input array size: ");

    size = Convert.ToInt32(Console.ReadLine());
    if (size<0)
        Console.Write("Invalid array size!!! ");
}

int maxStringSize=-1;
while (maxStringSize<0)
{
    Console.Write("Input maximum string size: ");
    
    maxStringSize = Convert.ToInt32(Console.ReadLine());
    if (maxStringSize<0)
        Console.Write("Invalid maximum string size!!! ");
}

string[] arr = CreateEmptyArray(size).FillArray();
arr.ShowArray();