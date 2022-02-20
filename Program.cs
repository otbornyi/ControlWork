Console.WriteLine("Введите слова либо цифры через пробел: ");
string text = Console.ReadLine();
string[] FirstArray = text.Split(new Char[] { ' ' });
void FillFinnalArray(string[] Final)
{
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if(FirstArray[i].Length < 4)
        {
            Final[i] = FirstArray[i];
        }
    }
}

void PrintFinalArray(string[] Final)
{
    for (int i = 0; i < Final.Length; i++)
    {
        Console.Write($"{Final[i]} ");
    }
}

string[] Final = new string[FirstArray.Length];
FillFinnalArray(Final);
PrintFinalArray(Final);