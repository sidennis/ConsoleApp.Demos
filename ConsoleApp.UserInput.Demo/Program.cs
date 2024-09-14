//Declaring Varaibles
string name = string.Empty;
int age = 0;
int retirementAge = 65;

//Prompt the user for input
Console.WriteLine("Enter your name:");
name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

//Process the Data
int workingYearsRemaining = retirementAge - age;

//Output results to the user
Console.WriteLine($"Full Name {name}");
Console.WriteLine($"Age {age}");
Console.WriteLine($" working years remaining {workingYearsRemaining}");



