//Declare varaibles

using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;


// User input 

Console.WriteLine("What is your firstname?: ");
firstName = Console.ReadLine();

Console.WriteLine("What is your lastname?: ");
lastName = Console.ReadLine();

Console.WriteLine("How old are you? ");
age = Convert.ToInt32(Console.ReadLine());

// Process

int workingyearsRemaining = age - retirementAge;

//The output

Console.WriteLine($"Your fullname: {firstName} {lastName}");
Console.WriteLine($"You are {age} years old");
Console.WriteLine($"Retirement age is {retirementAge}");