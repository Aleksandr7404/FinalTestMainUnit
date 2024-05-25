// Задача: Написать программу, которая из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = ["Hello", "my", "crazy", "word", "!"];
string[] new_array = new string[array.Length];

int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        new_array[index] = array[i];
        index++;
    }
}

Console.Write("[");
for (int i = 0; i < index; i++)
{
    Console.Write($"'{new_array[i]},'");
}
Console.Write("]");


