/*
int num; 

Console.Write("Введите целое число : ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Resultat is " + num*num);


int num1, num2, quad;

Console.Write("Input first number : ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
num2= Convert.ToInt32(Console.ReadLine());

quad = num2*num2;

if (num1 == quad)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");

}
/*int num;

Console.Write("Введите число ");

num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num*num);

ДЗ-1

int num1 ,num2;

Console.WriteLine("Введите первое число " );
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число " );
num2 = Convert.ToInt32(Console.ReadLine());

if (num1<num2)
{
    Console.WriteLine("Второе число больше и это  : " + num2 );
}

else
{
    Console.WriteLine("Первое число больше и это  : " + num1 );
}

ДЗ-2

int num1 , num2 , num3, max ;

Console.WriteLine(" Input number 1 " );
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (" Input number 2 " );
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input number 3 " );
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > max) max = num2;

if (num3 > max) max = num3;

Console.WriteLine( " Maximum number is " + max);

ДЗ-3

int num;

Console.WriteLine("Input number");
num = Convert.ToInt32(Console.ReadLine());


if (num % 2 == 0 )
   
{   
    Console.WriteLine("Число четное ");

}

else   
{   
     
    Console.WriteLine("Число нечетное ");
}



int num, i ;

i=2;

Console.WriteLine ("Input number");
num = Convert.ToInt32(Console.ReadLine());

while (i <= num ) 
{
    Console.WriteLine(i );
    i=i+2;

}


 int num ; 

Console.WriteLine("Input number");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 2 == 0 ? "Четное" : "Не четное");



int Max(int arg1, int arg2, int arg3)
{
    int result=arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}

int a1=5;
int b1=8;
int c1=2;
int a2=12;
int b2=1;
int c2=4;
int a3=112;
int b3=11;
int c3=14;

int max1=Max(a1,b1,c1);

Console.WriteLine(max1);


int Max(int a,int b,int c)
 {
     a=2;
     b=5 ;
     c=1;
     
 }
 Console.WriteLine(Max);
 
 
 Семинар 2


__________________________________________
Метод сложения двух чисел

int SumTwoNum ( int num1,int num2 )
{ 
    int sum = num1+num2;
    return sum;

}

Console.WriteLine("input num1");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input num2");
int num2=Convert.ToInt32(Console.ReadLine());
int cy=SumTwoNum(num1,num2);

Console.WriteLine(cy);






 int num1,num2,sum;

Console.WriteLine("input num1");
num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input num2");
num2=Convert.ToInt32(Console.ReadLine());
sum=num1+num2;



Console.WriteLine(sum);

Дом Задание ,Задача 2 (Вывести второе число )по второму семинару

____________________________________________


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


_______________________________________

int num1,pip;

Console.WriteLine("input three digit number");
num1 = Convert.ToInt32(Console.ReadLine());

if(num1 > 99 && num1 < 1000)
{
    pip = num1 / 10 % 10;
    Console.WriteLine(pip);
}
else 
{
    Console.WriteLine("Bad number");
}
________________________________________



___________________________________________________
 ДЗ 2 семинар 3 задача
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
____________________________________________________




int num1;

Console.WriteLine("Input number of day week");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1 >= 1 && num1 <= 5)
    {
        Console.WriteLine("No, It is a work day");
    }
if (num1 >= 6 && num1 <= 7)
    {
       Console.WriteLine("Yes, it is a Holiday"); 
    }
if (num1 > 7)
{
    Console.WriteLine("Incorrect day of te week");
}

   
_____________________________________________________

Вторая задача по семирнару 2(Без метода)


int num;

Console.WriteLine("Input Number");
num=Convert.ToInt32(Console.ReadLine());

if (num < 100)
    {
        Console.WriteLine("А вот третьей цифры то и нету))");
    }


while  (num > 999 ) 
{
    num = num/10;  
    
}
if (num > 99 && num < 1000)

   { num = num % 10;
    Console.WriteLine(num);
    
    }
  


__________________________________________
Задача 2(метод)(Семинар 2)

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
________________________________________________


*/
//_____________________________________________________

//Семинар 3

/*
int FinfQuart(int x,int y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return -1;                           
}

int res= FinfQuart(2,4);
if (res == -1) Console.WriteLine("wrong");
else Console.WriteLine(res);


/*

void QuadN(int n)
{
    int count=0;
    int quad;
    while (count <= n ) 
    {
        
        count ++;
        quad=n*n;
        
        
    }
    

}
int num1;
Console.WriteLine("Введите номер");
num1=Convert.ToInt32(Console.ReadLine());

QuadN(num1);


/*int num;
 Console.WriteLine("введите число");
 num=Convert.ToInt32(Console.ReadLine());*/
 


sbyte ur=3;
Console.WriteLine(ur);






 











