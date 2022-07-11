/*
Задача 1

string [] words= { "vwe", "aer", "art", "rty", "tyu"};
int NumWord(string [] massive)
{
    int count=0;
    string letters="aeiouy";
    for(int i=0;i<massive.Length;i++)
    {
        for( int j=0;j<letters.Length;j++)
        {
           if (massive[i][0]==letters[j]) count++; 
        }
        
    }
    return count;
}
Console.WriteLine(NumWord(words));


Задача 2

string [] words= { "vwe", "aer", "art", "rty", "tyu", "bub","pip"};
string [] NumWord(string [] massive)
{
    string []array=new string[massive.Length];
    for(int i=0; i<massive.Length-1;i=i+2)
    {
        array[i]=massive[i]+massive[i+1];
        Console.WriteLine(array[i]);
        
    }   
    return array;
} 
NumWord(words); */

