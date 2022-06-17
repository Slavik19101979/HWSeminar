
/* Задача 1(Трехзначное число на входе и второе на выходе) 

int TwoNum (int num)
{
    
    if (num > 99 && num < 1000 )
    {
        int pip = num/ 10 % 10;
        return pip;
       
    }
    else
    {

        return -1;

    }
}

Console.WriteLine("input three digit number");
int num1 = Convert.ToInt32(Console.ReadLine());

int resultat = TwoNum(num1);
if (resultat == -1)
{
    Console.WriteLine("Your Number incorrect");
}

Console.WriteLine(resultat);
/*
Задача 2(Вывод третьей цифры заданного числа 
или отсутствие третьей цифры)

int ThGig(int num)
{
    if (num < 100)
    {
        return -1;
    }
    while (num > 999 )
    {
        num = num/10;
        
    }
     if (num > 99 && num < 1000)

   { 
       num = num % 10;
       }
       
    return num;   
    
}
int num1;

Console.WriteLine("Введите номер");
num1=Convert.ToInt32(Console.ReadLine());

int resultat=ThGig(num1);
Console.WriteLine(resultat);

if(resultat == -1)
{
    Console.WriteLine("А вот третьей цифры то и нету))");
}

Задача 3(Про выходные-рабочие дни)

int Weekend (int num)

{
    if (num >= 1 && num <= 5)
    { 
      
        return -1;
    }
    if (num >=6 && num <=7)
    {
        
        return -2;
    }
    if (num > 7)
    {
       
       return -3;  
    }
    return num;
    
}
int num1;

Console.WriteLine("Input number of day week");
num1 = Convert.ToInt32(Console.ReadLine());

int resu=Weekend(num1);
if (resu == -1)
{
    Console.WriteLine("No, It is a work day");
}
if (resu == -2)
{
    Console.WriteLine("Yes, it is a Holiday");
}
if (resu == -3 )
{
    Console.WriteLine("Incorrect day of te week");
}



int num, Aa,Bb,Cc,Dd;
 Console.WriteLine("введите число");
 num = Convert.ToInt32(Console.ReadLine());

 Aa = num / 10000;
 Bb = num % 10000 / 1000;
 Cc = num % 10;
 Dd = num % 100 / 10;
  if (Aa == Cc && Bb == Dd)
  {
      Console.WriteLine("Уау,это палиндром!!");

  }

  else 
  {
      Console.WriteLine("Это обычное число");
  }
  

________________________________________________

ДЗ по семинару 3.Задача  1

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
 

using System;
namespace Program1
{
    public class Program
    {
        static void Main(string[] args)

    {
        Console.WriteLine("Enter name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Hello " + name);
        Console.WriteLine("Push for exit...");
        Console.ReadLine();
}
    }
    }
    
    
___________________________________________________________

//Задача на семинаре про поиску четверти координат

    double FindQuad(double x, double y)
    {
        if(x>0 && y>0 ) return 1;
        if(x<0 && y>0 ) return 2;
        if(x<0 && y<0 ) return 3;
        if(x>0 && y<0 ) return 4;
           
        return -1;

    }

Console.WriteLine("Enter x");
double x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y");
double y=Convert.ToInt32(Console.ReadLine());
double res=FindQuad(x,y);


Console.WriteLine($"Точка находится на {res} четверти");



double fahr = 100;
double celsius = (fahr - 32)*(5.0/9.0);
Console.WriteLine($"Температура {celsius}");


//___________________________________________________
//Домашнее по семинару 3 ,задача с кубом 3


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

________________________________________________________-



double aso;
double pip=4;
double fun=Math.Pow((5),2);
aso= Math.Sqrt(4);
Console.WriteLine(aso+fun);



//Семинар 4

int FindSumDig(int num)
{
    int sum=0;
    while (num >0)
    {
         sum += num%10;
         num /= 10;

    }
    return sum;
}
int n=234;
int result=FindSumDig(n);
Console.WriteLine(result);


int KolMum(int num)
{
    int curent=0;
    while (num >0)
    {
        num=num/10;
         curent ++ ;
         

    }
    return curent;
}
int n=54321;
int result=KolMum(n);
Console.WriteLine(result);

__________________________________________________________________

Программа с ошибкой цифрой2


void Count(int a)
{
    int counter = 0;
    while (a > 0)
    {
        counter++;
        a = a / 10;
        
    }
    Console.WriteLine("Count of digits in your number is: " + counter);
}
int a = Convert.ToInt32(Console.Read());
Count(a);




___________________________________________________________________________________

Дом зад по координатам в 3д

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



_________________________________________________________________
Экспериминтирую с new Random().Next()

int n=new Random().Next(10);
Console.WriteLine(n);




int c=new Random().Next(0,200);
Console.WriteLine(c);
int sum=n+c;
Console.WriteLine(Math.Pow ((n),3));


//________________________________________________________________________________

//Пример работ начало работы с массивом семинар 4

int size=4;
int [] array = new int[size];
for (int i=0; i<size; i++)
{
    array[i] = new Random().Next(0,2);
}
for (int i=0; i<size; i++)
{
    Console.Write(array[i]+ " ");
}
______________________________________________________________________________

*/
int Max(int num1,int num2,int num3)
{
    int max=num1;
    if (num2>num1) max=num2;
    if (num3>num2) max=num3;
    return max;
}
int [] pump={new Random().Next(0,2)};
 int result=Max(pump[0],pump[1],pump[2]);

Console.WriteLine(result);

 


 









