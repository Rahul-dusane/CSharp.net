// See https://aka.ms/new-console-template for more information

//While Loop To Repeat The Operation

/* You'll use loops to repeat statements 
 * that you want executed more than once. 
*/

Console.WriteLine("While Loop Itration :");
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The Counter Is {counter}.");
    counter++;
}

//Do....While Loop To Repeat The Operation

/*The while loop tests the condition before executing the code following the while.
 * The do ... while loop executes the code first, and then checks the condition.
*/

Console.WriteLine("Do...While Loop Itration :");
int counter1 = 0;
do
{
    Console.WriteLine($"Hello World! The Counter Is {counter1}.");
    counter1++;
} while (counter1 < 10);


//For Loop To Repeat The Operation

Console.WriteLine("For Loop Itration :");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello World! The Counter Is {i}.");
}

//Foreach Loop To Repeat The Operation

Console.WriteLine("Foreach Loop Itration : ");
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}