// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// int size = 5;
// Console.Write("Укажите размер архива ");
// size = Convert.ToInt32(Console.ReadLine());
// string[] CreateArray (int length)
// {
//     string[] array = new string[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = Console.ReadLine();
//     }
//     return array;
// }

int GetCount (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}

string[] GetResult (string[] array, int count)
{
    string[] result = new string[count];
    int mark = 0;
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = mark; j < array.Length; j++)
        {
            if (array[j].Length < 4)
            {
                result[i] = array[j];
                mark = j + 1;
                break;
            }
        }
    }
    return result;
}

Console.WriteLine ("Задайте элементы массива: ");
// string[] strings = CreateArray (size);
string[] strings = {"Hello", "2", "word","Sun", "45"};
Console.WriteLine($"Массив: [ {string.Join("; ", strings)} ]");
int count = GetCount(strings);
string[] result = GetResult(strings, count);
// Console.WriteLine(count);
Console.WriteLine($"результат: [ {string.Join("; ", result)} ]");