Console.WriteLine("Введите слова либо цифры через пробел: ");
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

void Choise(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        string Z = A[i];
        if (Z.Length < 4)
        {
            Console.Write($"{A[i]} ");
        }
    }
}

string[] A = new string[K];
FillArray(A);
Choise(A);