// See https://aka.ms/new-console-template for more information

Console.Write( "Please Enter number 1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Please Enter number 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
 * Math opereations and Operators
 */


// Add
int sum = num1 + num2;
//Multiplication 
int product = num1 * num2;
//Division
int quotient = num1 / num2;
//Subtraction 
int defference = num1 - num2;
//Modulus
int mod = num1 % num2;

Console.WriteLine(".........Math Results.........");
Console.WriteLine();
Console.WriteLine($"Sum {sum}");
Console.WriteLine($"product {product}");
Console.WriteLine($"quotient {quotient}");
Console.WriteLine($"Defference {defference}");
Console.WriteLine($"Mod {mod}");
Console.WriteLine();
Console.WriteLine("...........End Math Results..........");

/*
 * Logical operations and Operators
 */

var isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqual = num1 == num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine(".......Begin Logic Results.......");
Console.WriteLine();
Console.WriteLine($"Is greater than {isGreaterThan}");
Console.WriteLine($"Is Less Than {isLessThan}");
Console.WriteLine($"Is Equal {isEqual}");
Console.WriteLine($"Is greater than or Equal {isGreaterThanOrEqual}");
Console.WriteLine($"Is Less than or Equal {isLessThanOrEqual}");
Console.WriteLine($"Is not Equal {isNotEqual}");
Console.WriteLine();
Console.WriteLine("........End Logic Results......");

/*
 * Assignment operators and operations
 */

Console.Write("Enter random value for assigned Assignment operations");
//int randomValue = 5;
//int increaseValue = num1 + 5;

//num1 = num1 + 5;
//num1 += 5;
//num1 -= 3;
//num1 /= 2;
//num1 %= 2;
//num1 = 10;

Console.WriteLine(".......Assignments  Results.......");
Console.WriteLine();
//num1 = num1 + randomValue
num1 += 5;
Console.WriteLine($"Num1 increased by 5:{num1}");
num1 -= 3;
Console.WriteLine($"Num1 reduced by 3: {num1}") ;
num1 /= 2;
//num = num1 - randomValue
Console.WriteLine($"Num1 divided by 2: {num1}");
//num1 = num1 / randomValue
num1 %= 2;
Console.WriteLine($"Num1 mod by 2: {num1}");
//num1 = num1 % randomValue 
Console.WriteLine();
Console.WriteLine("........End Assignments Results......");

