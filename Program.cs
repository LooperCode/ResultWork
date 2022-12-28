string[] FillArray (string []insert, int n)
{
    
    for (int i = 0; i < insert.Length; i++)
    {
        Console.Write($"Введите значение элемента {i}: ");
        insert[i] = Convert.ToString(Console.ReadLine());
    }
    return insert;
}



Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] insert = new string[n];
FillArray(insert, n);





