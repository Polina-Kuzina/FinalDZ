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
