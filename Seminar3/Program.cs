/*

Задача 1(про палиндром)

void PaliN(int num)
{
 int  Aa = num / 10000;
 int Bb = num % 10000 / 1000;
 int Cc = num % 10;
 int Dd = num % 100 / 10;
 
 if (Aa == Cc && Bb == Dd)
 {
     Console.WriteLine("Уау,это палиндром!!");
 }

 else 
  {
      Console.WriteLine("Это обычное число");
  }
  
}
int num;
Console.WriteLine("введите число");
 num = Convert.ToInt32(Console.ReadLine());
 PaliN(num);

_______________________________________________
Задача 2(Координаты в 3д)

double FindLenght3D( double xA, double xB,double yA,double yB, double zA,double zB )
{
   return Math.Sqrt((Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2)+Math.Pow((zB-zA),2)));
      
}
Console.WriteLine("Введите координаты точки xA ");
double xA=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки xB ");
double xB=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки yA ");
double yA=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки yB ");
double yB=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки zA ");
double zA=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки zB ");
double zB=Convert.ToDouble(Console.ReadLine());


 double res=FindLenght3D(xA,xB,yA,yB,zA,zB);
 Console.WriteLine(res);


_____________________________________________

Задача 3(про куб)

void Cub(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine(Math.Pow((i),3));
        i ++;
        
    }
}

Console.WriteLine("введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Cub(num1);

Все...*/

