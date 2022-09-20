// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритмы. При решении не рекомендуется пользоваться коллекциям, лучше обойтись исключительно массивами.

// ["hello","2","world",";-)"] > ["2",":-)]

string[] sourcearray = new string[] { "1", "2", "hello", "world", "res", "tst", ":-)" };

void FindElement(string[] array3)
{

    Console.Write("[");
    for (int i = 0; i < array3.Length; i++)

    {

        if (array3[i].Length <= 3)
        {
            Console.Write($"\"{array3[i]}\",");

        }

    }
    Console.Write("]");
}

FindElement(sourcearray);


