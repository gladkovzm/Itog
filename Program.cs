Console.Clear();
string[] first;
Console.WriteLine("Введите массив через пробел, чтобы вывести массив с 3мя и менее символами");
string prob = Console.ReadLine();
first = prob.Split(' ');
var result = new string[first .Length];
var realSize = 0;

foreach (var arr in first )
{
    if (arr.Length <= 3)
    {
        result[realSize] = arr;
        realSize++;
    }
}
PrintArray(result);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



            					