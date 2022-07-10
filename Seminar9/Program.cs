/*Задача 1 

int SumNums (int min, int max)
{
    if (min == max)        
    return min;
    else return  max+SumNums(min,max-1);
}

Console.Write("Input lesser integer positive number" );
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input bigger integer positive number" );
int num2 = Convert.ToInt32(Console.ReadLine());


Console.Write(SumNums(num1,num2)) ;
 

Задача 2

int ShowAmount(int num)
{
    if(num>=0 && num<10)
    return 1;
    else return 1+ShowAmount(num/10);
}
Console.Write("Input bigger integer positive number" );
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write(ShowAmount(num1)) ;
*/ 