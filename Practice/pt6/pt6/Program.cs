// See https://aka.ms/new-console-template for more information

//Create Lists.....

/*
 * Here,We Have Created A List Of String ,
 * And Itrate The Operation Using Foreach Loop
 */

/*
 * The collection you created uses the List<Type> type. 
 * This type stores sequences of elements. You specify 
 * the type of the elements between the angle brackets.
 */

var names = new List<string> { "Rahul", "Vraj", "Jagdish" };
foreach(var name in names)
{
    Console.WriteLine($"{name.ToUpper()}..!");
}

//You've added two more names to the end of the list. You've also removed one as well. 
Console.WriteLine();
names.Add("Uday");
names.Add("Samyul");
foreach(var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}..!");
}

Console.WriteLine($"My Name Is {names[0]}.");

// Here, We Use ---> var_name.Count <--- For Count The Number Of Elements In The List.
Console.WriteLine($"The List Has {names.Count} People In It.");
