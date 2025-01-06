// See https://aka.ms/new-console-template for more information
    
// Integer Precision And Limits......

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"Quotient: {d}");
Console.WriteLine($"Reminder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The Range Of Integer Is {min} To {max} .");

int what = max + 3;
Console.WriteLine($"An Example Of Overflow: {what}");


// Double Precision And Limits.......

double a1 = 5;
double b1 = 4;
double c1 = 2;
double d1 = (a + b) / c;
Console.WriteLine(d1);

double a2 = 19;
double b2 = 23;
double c2 = 8;
double d2 = (a + b) / c;
Console.WriteLine(d2);

double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The Range Of Double Is {min1} To {max1} .");

double third = 1.0 / 3.0;
Console.WriteLine(third);

// Work with Decimal Types.......

decimal max2 = decimal.MaxValue;
decimal min2 = decimal.MinValue;
Console.WriteLine($"The Range Of The Decimal Tyep Is {min2} To {max2} .");

decimal third1 = 1.0M / 3.0M;
Console.WriteLine(third1);

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine($"The Area Of The Circle Is {area} ."); ;