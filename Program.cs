string[] Ar1 = new string[6] {"pirat", ":)", "lol", "World", ")9()()","massiv"};
string[] Ar2 = new string[Ar1.Length];

    void SecondArray(string[] Ar1, string[] Ar2)
    {
        int count = 0;
        for (int i = 0; i < Ar1.Length; i++)
        {
        if(Ar1[i].Length <= 3)  
            {
            Ar2[count] = Ar1[i];
            count++;
            }
        }
    }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(Ar1, Ar2);
PrintArray(Ar2);