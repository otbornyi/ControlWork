Console.WriteLine("Введите слово или цифры: ");
string test = Console.ReadLine();
string[] temp = test.Split(new Char[] { ' ' });
int K = temp.Length;

void FillArray(string[] A)
{
    for (int i = 0; i < temp.Length; i++)
    {
        A[i] = temp[i];
    }
}