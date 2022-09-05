//------------------------------------------------------------------------
// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше либо равна 3
//------------------------------------------------------------------------

// Метод fillArray, который заполняет одномерный массив строк
string[] fillArray(int m)
{
    string[] outputArray = new string[m];
    
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите элемент массива строк с индексом {i}: ");
        string? inputLine = Console.ReadLine();
        if (inputLine != null) outputArray[i] = inputLine;
    }
    
    return outputArray;
}

// Метод ChangeArray, который изменяет массив согласно условию задачи
string[] ChangeArray(string[] inputArray)
{
    int arrayLenght = inputArray.Length;
    string[] outputArray = new string[] {};
    
    for (int i = 0; i < arrayLenght; i++)
    {
        if (inputArray[i].Length >= 3)
        {
            Array.Resize(ref outputArray, outputArray.Length+1);
            outputArray[outputArray.Length-1] = inputArray[i];
        }
    }

    return outputArray; 
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m)
{
    m = 0;
    
    Console.WriteLine("Введите размерность массива строк");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    
    if (inputFirstLine != null) m = int.Parse(inputFirstLine);
}

try 
{
    // Считываем данные с консоли
    int m;
    GetConsoleData(out m);

    // Заполняем массив
    string[] filledArray = fillArray(m);

    // Изменяем массив согласно условиям задачи
    string[] changedArray = ChangeArray(filledArray);

    // Выводим информацию
    Console.Write(
        $"[{string.Join(",", filledArray)}] -> [{string.Join(",", changedArray)}]"
    );
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
