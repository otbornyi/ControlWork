Console.WriteLine("Введите слова либо цифры через пробел: ");
string test = Console.ReadLine();
string[] temp = test.Split(new Char[] { ' ' });
int K = temp.Length;



for (int i = 0; i < temp.Length; i++)
{
    string Z = temp[i];
    if (Z.Length < 4)
    {
        Console.Write($"{temp[i]} ");
    }
}
