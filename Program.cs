Console.Clear();

int GetIntFromUser(string message)
{
    Console.Write(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}

string[] GenerateStringArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите элемент: ");
        string data = Console.ReadLine();
        array[i] = data;
    }
    return array;
}

int NumberOfElementsWithLessThenThreeLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
    {
        count++;
    }
    }
    return count;
}

string[] GenerateResultStringArray(string[] array, int threeElementString)
{
    string[] result = new string[threeElementString];

    for (int j = 0; j < result.Length;)
    {
    for (int i = 0; i < array.Length;)
    {
        if(array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
        i++;
    }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("\"");
        Console.Write(array[i]);
        Console.Write("\"");
        if (i < array.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int length = GetIntFromUser("Введите количество элементов: ");
string[] array = GenerateStringArray(length);
int threeElementString = NumberOfElementsWithLessThenThreeLength(array);
string[] resultArray = GenerateResultStringArray(array, threeElementString);
PrintArray(array);
Console.Write(" -> ");
PrintArray(resultArray);