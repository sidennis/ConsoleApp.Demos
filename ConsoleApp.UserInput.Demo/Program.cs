//Declare varaibles

string name = string.Empty;
int age = 0;
int retirementAge = 65;


// User input 

Console.WriteLine("What is your name?: ");
name = Console.ReadLine();

Console.WriteLine("How old are you? ");
age = Convert.ToInt32(Console.ReadLine());

// Process

int workingyearsRemaining = age - retirementAge;

//The output

Console.WriteLine($"You name is {name}");
Console.WriteLine($"You are {age} years old");
Console.WriteLine($"Retirement age is {retirementAge}");