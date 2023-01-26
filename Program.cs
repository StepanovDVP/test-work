//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.

// ** метод для получение массива ** 
List<string> EnterArr(string text)
{
    Console.WriteLine(text);
    var ls = new List<string>();
    Console.WriteLine("Для завершения нажмите (space) или");
    while (true)
    {
        Console.WriteLine("введите значение: ");
        string st = Console.ReadLine();
        if (st == " " ) break;
        else ls.Add(st);
    }
    return ls;
}

var someList = EnterArr("задайте массив");
Console.WriteLine($"[{string.Join(", ", someList)}]");