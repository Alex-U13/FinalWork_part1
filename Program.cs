Console.Clear();

void CreateArray (string[] Array)
{
        for (int i=0; i<Array.Length; i++)
        {
            Console.Write("Введите значение элемента массива: ");
            Array[i]=Console.ReadLine();
        }
}
void PrintArray (string[] Array)
{
    for (int i =0; i<Array.Length; i++)
    {
        if((i==(Array.Length-1)) && i==0)  Console.Write($"[{Array[i]}] ");
        else if(i==0)  Console.Write($"[{Array[i]}, ");
        else if(i==(Array.Length-1))  Console.Write($"{Array[i]}] ");
        else Console.Write($"{Array[i]}, ");
    }
}

Console.Write("Введите необходимое количество элементов массива: ");  
int n = Convert.ToInt32(Console.ReadLine());
string [] workArray = new string[n];

CreateArray (workArray);
PrintArray (workArray);

Console.WriteLine();

Console.Write("Введите требуемое ограничение по количеству символов для элемента нового массива: ");  
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

void SortArray (string[] Array)
{
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i].Length < num+1) count +=1;
    }

    string[] arrayNew = new string[count];
    int j =0;
    for (int i = 0; i<Array.Length; i++)
    {
        if(Array[i].Length < num+1)
        {
          arrayNew[j]=Array[i];
          j++;
        }
    }
    PrintArray (arrayNew);
}

SortArray (workArray);