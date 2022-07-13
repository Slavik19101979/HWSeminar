int countPeople = 1000;
double growth = 1.02;
int newPeople = 50;
int count = 0;

while (countPeople < 1200)
{
  countPeople = countPeople * growth + newPeople;
  count++;
}

Console.WriteLine($"Ответ: {count}");
