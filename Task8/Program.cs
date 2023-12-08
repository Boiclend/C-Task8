// Подсчитать количество повторений элементов, заданного множества символов,
// во введенной строке. Суть задачи такова, вводим строку символов,
// после чего подсчитываем количество повторений каждого символа в строке. 
// Таким образом количество повторений любого символа будет равно как минимум единице.

string Message(string message) {
    Console.WriteLine(message);
    string text = Console.ReadLine();
    return text;
}
void GetCountOfSymbols(string txt) { // поиск количества повторений каждого символа в строке
    foreach (char symbol in txt.Distinct().ToArray()) // Distinct() - удаляет дубликаты 
    {
        int count = txt.Count(chr => chr == symbol); // считаем количество повторений символа находящегося в переменной symbol
        Console.WriteLine($"Количество символов {symbol} = {count}");
    }
}

string Text = Message("введите строку");
GetCountOfSymbols(Text);

