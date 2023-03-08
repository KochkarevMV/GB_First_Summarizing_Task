// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


Console.Clear();
string [] array1 = {"ABC", "ABCD", "XYZ", "WXYZ", "123", "12345"};
string [] array2 = new string [array1.Length];

int LimitCheck = 3;
int k = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= LimitCheck)
    {
        array2[k] = array1[i];
        k++;
    }
}

Console.WriteLine($"Начальный массив: {string.Join(" ", array1)}");
Console.Write($"Конечный массив: {string.Join(" ", array2)}");