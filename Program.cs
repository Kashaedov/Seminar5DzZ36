int size = 7; 
int [] array = new int [size];


void FillArray (int [] array)

{
    Random random = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = random.Next (1, 100);
    }
}

void PrintArray (int [] array)
{
    Console.WriteLine ("Ввывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write (array[i] + "\t");
    }
   
}

void SumNeChetNumbers (int [] array)
{
    Console.WriteLine ();
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine ( $"Сумма элементов, стоящих на нечетных позициях = {sum}");
}


FillArray (array);
PrintArray (array);
SumNeChetNumbers (array);