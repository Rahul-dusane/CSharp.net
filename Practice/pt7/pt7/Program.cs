// See https://aka.ms/new-console-template for more information


  //List<string> is a generic collection that can store multiple values of type string.
  
  //new List<string>() tells the compiler to create a new list in memory where we can store strings.

  //Without using new, you would not have a valid object to work with, and trying to use names would 

  //result in a null reference error because the variable wouldn’t be pointing to an actual list.
 
var names = new List<string> { "<name>", "Rahul", "Vraj","ana", "felipe"};
foreach(var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()!}");
}

var names1 = new List<int> {1,2,3,4};
foreach (var name1 in names1)
{
    Console.WriteLine($"Hello {name1}!");
}

var index = names.IndexOf("felipe");
if(index != -1)
{
    Console.WriteLine($"The Name {names[index]} Is At Index {index}");
}

// varriable_name.IndexOf("...");
// Will Return The Index In The List
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When An Item Is Not Found, IndexOf Returns {notFound}...!");


// The Sort method sorts all the items in the list
// in their normal order (alphabetically for strings).
names.Sort();
foreach(var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}:");
}

var fibonacciNumber = new List<int> { 0 , 1 };

var previous = fibonacciNumber[fibonacciNumber.Count - 1];
var previous2 = fibonacciNumber[fibonacciNumber.Count - 2];

fibonacciNumber.Add(previous + previous2);

foreach(var item in fibonacciNumber)
{
    Console.WriteLine(item);
}

for(int i = 2; i <= 21; i++)
{
    int next = previous + previous2;
    fibonacciNumber.Add(next);
    previous = previous2;
    previous2 = next;
}

foreach(var item in fibonacciNumber)
{
    Console.WriteLine(item);
}