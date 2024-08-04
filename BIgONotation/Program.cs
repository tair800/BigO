
Console.WriteLine("Enter first number (a): ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number (b): ");
int b = int.Parse(Console.ReadLine());

int sum = a + b;

if (sum >= 10 && sum <= 99)
{
    Console.WriteLine("The sum is a 2-digit number.");
}
else if (sum >= 100 && sum <= 999)
{
    Console.WriteLine("The sum is a 3-digit number.");
}
else
{
    Console.WriteLine("Not considered.");
}

