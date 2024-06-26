//Declare Varaibles


string firstName = string.Empty;
string lastName = string.Empty;
int age  = 0;
int retirementAge = 65; 

//Prompt the user for Input

Console.WriteLine("Please Enter your name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please Enter your name: ");
lastName = Console.ReadLine();

Console.WriteLine("Please Enter age: ");
age  = Convert.ToInt32(Console.ReadLine());

//Process the Data

int WorkingYearsRemaining = retirementAge - age;

//Output the results to the user:

Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining : {WorkingYearsRemaining}");

