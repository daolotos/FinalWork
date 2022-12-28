// See https://aka.ms/new-console-template for more information

string[] array = new string[5] { "Hello World", ";)", "Ice", "Hello Bali", "yes" };
string[] array3 = new string[array.Length];

PrintArray(array, "Исходный массив:");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        array3[count++] = array[i];
}

PrintArray(array3, "Массив из строк 3 символа или менее:");


static void PrintArray(string[] array, string title)
{
    Console.WriteLine(title);
    foreach (var s in array)
        Console.WriteLine(s);
    Console.WriteLine();
}