
/* Задача 1

Console.Write("Введите колличество чисел,которое вы хотите ввести : ");
int usernum=Convert.ToInt32(Console.ReadLine());

PositivNumbers(usernum);

void PositivNumbers(int num)
{
    int count=0;
    int ammount=0;
    while (ammount<usernum) 
    {
        Console.Write("Введите число :  " );
        int number=Convert.ToInt32(Console.ReadLine());
        if (number >0) count++; ammount++;
    }
    Console.WriteLine("Колличество положительных чисел = " + count );

}
_____________________________________
Задача 2

int [] RandomMassive(int size)
{
    int[] massive = new int [size];
    for( int i=0; i<massive.Length; i++)
    {
        massive[i]=new Random().Next(-100,100);
        Console.Write(massive[i] + "  ");
    }
    return massive;
}
Console.Write("Original : " + "  ");
int [] pip=RandomMassive(8);

int [] CloneMassive(int [] array)
{
    int[] clonearray=new int[pip.Length];
    for(int i=0;i<clonearray.Length;i++)
    {
        clonearray[i]=pip[i];
        Console.Write(clonearray[i] + "  ");
    }
    return clonearray;
}

Console.WriteLine();
Console.Write("Copy     : " + "  ");
CloneMassive(pip);

*/

