Console.WriteLine("Введите слова либо цифры через пробел: ");
string text = Console.ReadLine();
string[] WordsNumbers = text.Split(new Char[] { ' ' });

for (int i = 0; i < WordsNumbers.Length; i++)
{
    string Z = WordsNumbers[i];
    if (Z.Length < 4)
    {
        Console.Write($"{WordsNumbers[i]} ");
    }
}
