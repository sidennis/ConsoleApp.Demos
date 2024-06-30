//Declare Varaibles

string firstName = string.Empty;
string lastName = string.Empty;
int age  = 0;
int retirementAge = 65; 
decimal salary = 0;
char gender = char.MinValue;
bool Working = false;

//Prompt the user for Input

Console.Write("Please Enter your firstname: ");
firstName = Console.ReadLine();

Console.Write("Please Enter your lastname: ");
lastName = Console.ReadLine();

Console.Write("Please Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please Enter your gender: [M / F] ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working: [True or False]");
Working = Convert.ToBoolean(Console.ReadLine());


//Process the Data

int WorkingYearsRemaining = retirementAge - age;

//Output the results to the user:

Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is {salary}");
Console.WriteLine($"Your gender is {gender}");
Console.WriteLine($"You are working {Working}");
Console.WriteLine($"Number of Working years remaining : {WorkingYearsRemaining}");

