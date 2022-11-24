// Написать программу, которая из имеющегося массива строк формирует массив из строк длина которых меньше или равна 3

void Main()
{
string[] ourArray = GetArray();
PrintArray(ourArray);
int maxSize = 3;
string[] newArray = SelectMoreThanSize(ourArray, maxSize);
Console.Write("\nСлова вашего массива, состоящие из трех или менее букв:");
PrintArray(newArray);
}

string[] GetArray()
{
    Console.WriteLine("Введите несколько слов через пробел");
    string ourLine = Console.ReadLine()!;
    string[] array = ourLine.Split(' ');
    return array;

}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}

string[] SelectMoreThanSize(string[] arr, int size)
{ string line = string.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length<=3)
        {
            line += arr[i] + ' ';
        }
    }
    string[] resultArray = line.Split(' ');
    return resultArray;
}
Main();