// Финальное ДЗ
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] text = { "hello", "2", "world", ":-)" };
Console.WriteLine("Исходный массив:");
PrintArray(text);
int sizeNewArray = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i].Length < 4) sizeNewArray++;
}
if (sizeNewArray > 0)
{
    string[] text2 = new string[sizeNewArray];
    int k = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length < 4)
        {
            text2[k] = text[i];
            k++;
        }
    }
    Console.WriteLine("Массив с количеством символов меньше или равно 3:");
    PrintArray(text2);
}
else Console.WriteLine("В исходном массиве нет нужных элементов");