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

// ** метод для сортировки и извлечения нужных данных массива **
List<string> Sorted(List<string> someList)
{ 
    var sortList = new List<string>();
    foreach (var item in someList)
    {
        if (item.Length <= 3) sortList.Add(item);
    }
    return sortList;
}

var sortList = Sorted(someList);
Console.WriteLine($"[{string.Join(", ", sortList)}]");