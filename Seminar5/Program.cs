/*
Задача 1

int [] FillArray(int [] massive)
{
    for (int i=0;i<massive.Length;i++) 
    {
        massive[i]= new Random().Next(100,1000);
    }
    return massive;
}
int CountEvenNumbers(int [] massiveeven)
{
    int count=0;
    for(int i=0;i<massiveeven.Length;i++) 
    {
        if (massiveeven[i]%2==0) 
        count++;
    }
    return count;
}

int size=10;
int[] Array= new int [size];
FillArray(Array);
for (int i=0;i<Array.Length;i++) Console.Write(Array[i]+"  ");
Console.WriteLine();
Console.WriteLine ("Колличество нечетных чисел " + CountEvenNumbers(Array));

__________________________________________________________________________

Задача 2

int [] massiveRandomNum(int size,int min,int max)
{
    int [] massive  = new int [size];
    for (int i=0; i<size; i++)
    {
        massive[i]=new Random().Next(min,max+1);
        Console.Write(massive[i] + "  ");
        
    }
    
    return massive;

}

int SumOddNum(int [] array)
{
    int sum=0;
    for (int i=1; i<array.Length; i+=2)
    {
        sum=sum+array[i];
        
    }
    return sum;

}

int[] buratino = massiveRandomNum(12,0,20);
Console.WriteLine();
Console.WriteLine("Summ is  " + SumOddNum(buratino));


______________________________________________________

Задание 3


double [] DoubMassiv (int size)
    {      
        double [] array = new double [size];
    
        for(int i = 0;i < size; i ++)
    {
        array[i] = new Random().NextDouble()*100;
        Console.Write(array[i]+ "  ");
    }
        return array;
    }     
double MinMaxDifr(double [] massive)
{
    double max = massive[0];
    double min = massive[0];
    
    for (int i = 0;i < massive.Length; i++)
    {
        if (massive[i]>max) max = massive[i];
        if (massive[i]<min) min = massive[i];
    }
    
    double difr = min - max;
    return difr;
}

double [] pip = DoubMassiv(3);
Console.WriteLine();
Console.WriteLine ("Разница между максимальным и минимальным значением" + "  "  +  MinMaxDifr(pip));


*/

