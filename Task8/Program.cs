string Message(string message) {
    Console.WriteLine(message);
    string text = Console.ReadLine();
    return text;
}
void GetCountOfSymbols(string txt) {
    foreach (char symbol in txt.Distinct().ToArray())
    {
        int count = txt.Count(chr => chr == symbol);
        Console.WriteLine($"Количество символов {symbol} = {count}");
    }
}

string Text = Message("введите строку");
GetCountOfSymbols(Text);

