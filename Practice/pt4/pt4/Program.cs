// See https://aka.ms/new-console-template for more information

// Make decisions using the if statement......

int a = 5;
int b = 6;
if (a + b > 10)
{
    Console.WriteLine("The Answer Is Greater Then 10 .");
}

// Make if and else work together........

int a1 = 5;
int b1 = 3;
if(a1 + b1 > 10)
{
    Console.WriteLine("The Answer Is Greater Then 10 .");
}
else
{
    Console.WriteLine("The Answer Is Less Then 10 .");
}

int c1 = 4;
if((a1 + b1 + c1 > 10) && (a1 == b1))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
