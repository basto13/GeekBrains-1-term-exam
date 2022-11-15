// Из имеющегося массива сформировать массив из строк, 
// длина которых меньше либо равна 3 символам.

Console.Write("The list of items are: ['hello', '2', 'world', ':-)']");

string[] list = new string[] { "hello", "2", "world", ":-)" };
string[] newList = new string[list.Length];

void formNewList(string[] list, string[] newList)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i].Length < 4)
        {
            newList[count] = list[i];
            count++;
        }
    }
}

void printList(string[] newList)
{
    Console.WriteLine();
    Console.WriteLine("New list is ");
    for (int i = 0; i < newList.Length; i++)
    {
        Console.WriteLine($"{newList[i]} ");
    }
}

formNewList(list, newList);
printList(newList);
