// The 'for' loop performs iterations through a specific block of code. 
// Iteration means adding something step by step, and the loop repeats this process. 
// The 'for' loop syntax starts with the 'for' keyword, and inside the parentheses () we pass parameters.
// The first parameter is the iterator, which is a variable initialized to 0.
// After that, we set a condition that determines until when the loop should run. 
// This is the "goal" of the loop and how the iteration will happen.
//
// Example 1:
for (int i = 10; i >= 0; i--)
{
    // In this example, the iterator 'i' starts at 10. 
    // The loop runs as long as 'i' is greater than or equal to 0.
    // After each iteration, 'i' is decreased by 1 and printed to the console.
    Console.WriteLine(i);
}

// Example 2:
for (int i = 0; i < 10; i++)
{
    // In this case, the iterator 'i' starts at 0. 
    // The loop runs while 'i' is less than 10. 
    // After each iteration, 'i' is increased by 1 and printed to the console.
    Console.WriteLine(i);
}

//Experiment with the iterator pattern
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

//Use the break keyword to interrupt the iteration statement
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

// Iterate through the 'names' array in reverse order. 
// We use 'names.Length - 1' to start from the last index (since array indices start at 0, the last index is Length - 1).
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

//The foreach loop provides read-only access to the elements of the array, so you cannot modify the original values during iteration.
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

//The for loop allows direct access to the array indices, enabling modifications to the original elements.
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);