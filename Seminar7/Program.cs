/* 
Задача 1 Семинар 7 (Двухмерный массив, заполненный случайными вещественными числами)

double [,] Random2DMassive(int a,int b)
{
  double [,] array = new double [a,b];
  for(int i=0;i<array.GetLength(0);i++)
  {
      for(int j=0;j < array.GetLength(1);j++)
      {
          array[i,j]= new Random().NextDouble()*100;
          // можно сделать вот так: Math.Round(new Random().NextDouble()*100,2); 
        Console.Write(array[i,j] + "      " );

      }
      Console.WriteLine( );

  }
  return array;
  
}
double[,] pip = Random2DMassive(4,4);
_____________________________________________________

Задача 2 Семинар 7

int [,] Massive2D=new int[,]{{4,6},{12,3},{9,6},{2,5},{6,12}};
Console.WriteLine("Enter number 1 ");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2 ");
int num2=Convert.ToInt32(Console.ReadLine());


if (num1< Massive2D.GetLength(0) && num2<Massive2D.GetLength(1) && num1>=0 && num2>=0)

Console.WriteLine(Massive2D[num1,num2]);

else Console.WriteLine ("такого элемента нет");


_________________________________________________ 

//Задача 3 Семинар 7(Двухмерный массив ,сумма и среднее арифметическое столбцов)

 int [,] CreatRandom2DArray(int a,int b)
{
    
    int[,] newMatrix=new int[a,b];

    for (int i=0;i<newMatrix.GetLength(0);i++)
    {
        for(int j=0;j<newMatrix.GetLength(1);j++)
        {
            newMatrix[i,j]=new Random().Next(0,9);
            Console.Write(newMatrix[i,j] + "  ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

void CountColumn(int [,] array)
{    
    for (int j=0;j<array.GetLength(1);j++)
    {
       int count=0;

        for (int i=0;i< array.GetLength(0);i++)
        {
            count=array[i,j]+count; 
                
        }       
        count=count/array.GetLength(0);
        Console.Write(count + "  ");
    }
    
}
int [,] pip=CreatRandom2DArray(4,3);
Console.WriteLine("________");
CountColumn(pip);
 
 */

