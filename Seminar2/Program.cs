
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

*/









