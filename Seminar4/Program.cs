/*Задача 1 по Семинару 4

double TwoN ( int num1, int num2)
{
    return  Math.Pow ((num1),num2);   
}

Console.WriteLine("Введите число А");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую хотите возвести число А");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TwoN(a,b));

___________________________________________________________________________

//Задача 2 по семинару 4
//Можно было ввести переменную для размера элементов массива,но я не стал

int [] massive = new int [8];
for (int i = 0;i < 8;i++)
{
    massive[i]=new Random().Next(1,60);
    Console.Write(massive[i]+" ");
}
*/