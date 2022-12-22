// Написать программу, которая из имеющегося массива строк, формирует 
// массив из строк длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте.

void Print(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i]} ");
    System.Console.WriteLine();
}

string[] Newarray(string[] oldarray)
{
    string[] newa = new string[oldarray.Length];
    for (int i = 0; i < oldarray.Length; i++) if (oldarray[i].Length <= 3) newa[i] = oldarray[i];
    return newa;
}

string[] array = { "dsa21", "f2q", "24q2" };
System.Console.WriteLine("Элементы текущего массива: ");
Print(array);

string[] newarray = Newarray(array);
System.Console.WriteLine("Элементы нового массива: ");
Print(newarray);