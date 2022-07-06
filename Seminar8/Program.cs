/* Задача 1
Сортировка строк двухмерного массива

int[,] CreateRandomArray2d ( int a, int b, int min, int max) 

{
     int [,] matrix=new int [a,b];
     for (int i = 0; i < a; i++)

    {
        for (int j = 0; j < b; j++)
            matrix[i,j] = new Random().Next(min, max+1);
        
    }
    return matrix;
}

void ShowArray2d(int [,] myarray)
{
    for (int i=0 ; i<myarray.GetLength(0); i++)
    {
        for ( int j=0 ; j<myarray.GetLength(1); j++)
            Console.Write(myarray [i,j] + "  ");

        Console.WriteLine();     
                
    }
    
}

int [,] SortLines(int [,]massive)
{
    int temp;
    
    for (int i=0;i<massive.GetLength(0);i++)
    {
        temp=0;
        for (int j=0; j<massive.GetLength(1)-1;j++)
        {
            for(int x=j+1;x<massive.GetLength(1);x++)
            {
                if(massive[i,x]<massive[i,j]) 
                {
                    temp=massive[i,j];
                    massive[i,j]=massive[i,x];
                    massive[i,x]=temp;
                }
            }
        }

    }   
    return massive;
}


int [,] pop=CreateRandomArray2d(5,6,1,9);
ShowArray2d(pop);
pop=SortLines(pop);
Console.WriteLine();
ShowArray2d(pop);


Задача 2  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

int[,] CreateRandomArray2d ( int a, int b, int min, int max) 

{
     int [,] matrix=new int [a,b];
     for (int i = 0; i < a; i++)

    {
        for (int j = 0; j < b; j++)
            matrix[i,j] = new Random().Next(min, max+1);
        
    }
    return matrix;
}

void ShowArray2d(int [,] myarray)
{
    for (int i=0 ; i<myarray.GetLength(0); i++)
    {
        for ( int j=0 ; j<myarray.GetLength(1); j++)
            Console.Write(myarray [i,j] + "  ");

        Console.WriteLine();     
                
    }
    
}

void NumberStr(int [,] massive)
{
        int sum=0;
        int maxsum=0;
        int maxline=0;
    
    for (int i=0 ; i<massive.GetLength(0); i++)
    {
        
        if (sum>maxsum) 
        {
            maxsum=sum ;
            maxline=i-1;
        }
        
         sum=0;
        
        for ( int j=0 ; j<massive.GetLength(1); j++)
        {
            
            sum=massive[i,j]+sum;
        }
    Console.WriteLine("Сумма элементов равна " + sum);

}
Console.WriteLine("Максимальная сумма : " + maxsum + " Находится в строке с индексом : " + maxline);
}

int [,] pop=CreateRandomArray2d(5,6,1,9);
ShowArray2d(pop);

Console.WriteLine();
NumberStr(pop);
 */

//Задача 3(Спиральный массив)

/* void ShowArray2d(int [,] myarray)
{
    for (int i=0 ; i<myarray.GetLength(0); i++)
    {
        for ( int j=0 ; j<myarray.GetLength(1); j++)
            Console.Write(myarray [i,j] + "  ");

        Console.WriteLine();     
                
    }
    
}
int [,]massive=new int[4,4];
ShowArray2d(massive);
Console.WriteLine();
FillAr2d(massive);
ShowArray2d(massive);

int [,] FillAr2d(int [,]array)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        array[0,j]=1;
    }
    for(int i=1;i<array.GetLength(0);i++)
    {
        array[i,3]=1;
    }
    for(int j=2;j>=0;j--)
    {
        array[3,j]=1;
    }
    for(int i=2;i>0;i--)
    {
        array[i,0]=1;
    }
    for(int j=1;j<array.GetLength(1);j++)
    {
        array[1,j]=1;
    }
    for(int i=1;i<array.GetLength(0);i++)
    {
        array[i,2]=1;
    }
    for(int j=1;j<array.GetLength(1);j++)
    {
        array[2,j]=1;
    }
    return array;
} */
