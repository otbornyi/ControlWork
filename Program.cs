Console.WriteLine("Введите слова либо цифры через пробел: ");
string text = Console.ReadLine();
string[] WordsNumbers = text.Split(new Char[] { ' ' });
string[] FinalArray = new string[0];

for (int i = 0; i < WordsNumbers.Length; i++)
{
    int j = 0;
    if (WordsNumbers[i].Length < 4)
    { 
        Array.Resize(ref FinalArray, j + 1);
        FinalArray[j] = WordsNumbers[i];
    }
    Console.Write(String.Join(" ", FinalArray));
}