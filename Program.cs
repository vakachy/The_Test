
// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] --> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] --> ["-2"]
// ["Russia", "Denmark", "Kazan"] --> []


int[] SearchString(string[] input, int searchLength)
{
    int size = input.Length;
    int[] positionMemo = new int[size];

    for (int j = 0; j < positionMemo.Length; j++)
    {
        positionMemo[j] = -1;
    }

    for (int i = 0; i < size; i++)
    {
        if (input[i].Length <= searchLength) positionMemo[i] = i;
    }
    return positionMemo;
}

void PrintResult(string[] input, int[] positionMemo)
{
    int size = positionMemo.Length;
    for (int i = 0; i < size; i++)
    {
        if (positionMemo[i] != -1) Console.Write($"\"{input[i]}\" ");
        // Console.Write($"\"{input[i]}\" ");
    }
}


string[] input = { "-2", "sun", "world", ":-)", "   " };
int searchLength = 3;

int[] positionMemo = SearchString(input, searchLength);
PrintResult(input, positionMemo);
