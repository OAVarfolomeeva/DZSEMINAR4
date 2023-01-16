int Sum(int number)
{
int sum = 0;
int place1 = 0;

for(int i = 0; i < number; i++)
{
    place1 = number - number % 10;
    sum = sum + (number - place1);
    number = number / 10;
}
return sum;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));
