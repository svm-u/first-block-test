/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/
Console.Clear();
void MoreThree(string[] array, string[] newArray)
{
    int countIndex = 0;
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i].Length < 4)
            {
            newArray[countIndex] = array[i];
            countIndex++;
            }
        } 
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите элементы массива через пробелы: ");
string? text  = Console.ReadLine();
string[] array = text.Split(' ');
PrintArray(array);
string[] newArray = new string[array.Length];
MoreThree(array, newArray);
PrintArray(newArray);
