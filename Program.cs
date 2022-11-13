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
        if(i==0)  Console.Write($"[{Array[i]}, ");
        else if(i==(Array.Length-1))  Console.Write($"{Array[i]}] ");
        else Console.Write($"{Array[i]}, ");
    }
}


Console.Write("Введите необходимое количество элементов массива: ");  
int N = Convert.ToInt32(Console.ReadLine());
string [] workArray = new string[N];

CreateArray (workArray);
PrintArray (workArray);

