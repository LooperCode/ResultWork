string[] FillArray (string []insert, int n)
{
    
    for (int i = 0; i < insert.Length; i++)
    {
        Console.Write($"Введите значение элемента {i}: ");
        insert[i] = Convert.ToString(Console.ReadLine());
    }
    return insert;
}

int CheckLength (string []insert, int count)
{
    
    for (int i = 0; i < insert.Length; i++)
    {
        
        if (insert[i].Length <= 3)
        {
            count += 1;
        }
    }
    return count;
}


Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] insert = new string[n];
FillArray(insert, n);
int count = 0;
string [] resultArr = new string [CheckLength(insert, count)];





