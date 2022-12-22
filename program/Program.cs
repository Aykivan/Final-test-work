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
    int size = 0;
    for (int i = 0; i < oldarray.Length; i++) size++; // ищем переменную size, для того чтобы задать длину нового массива

    string[] newa = new string[size];
    for (int i = 0; i < oldarray.Length; i++) if (oldarray[i].Length <= 3) newa[i] = oldarray[i]; // задаем значения нового массива

    return newa;
}

string[] array = { "dsa21", "f2q", "24q" };
System.Console.WriteLine("Элементы текущего массива: ");
Print(array);

string[] newarray = Newarray(array);
System.Console.WriteLine("Элементы нового массива: ");
Print(newarray);