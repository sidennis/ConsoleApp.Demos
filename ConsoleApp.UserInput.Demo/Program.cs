//Declaring Varaibles
string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

//Prompt the user for input
Console.Write("Enter your firstname: ");
firstName = Console.ReadLine();

Console.Write("Enter your lastname: ");
lastName = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your gender: (M / F) ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (True or False): ");
working = Convert.ToBoolean(Console.ReadLine());

//Process the Data
int workingYearsRemaining = retirementAge - age;

//Output results to the user
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"You are employed: {working}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");

//Console.WriteLine("My wife is coming soon");
















