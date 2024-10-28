// See https://aka.ms/new-console-template for more information

//Prompt the User

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
/*
 * Math Operators and Operators
 */

//Add Numbers
int sum = num1 + num2;
//Multiply
int product = num1 * num2;
//Division
int quoteint = num1 / num2;
//Subtraction
int deference = num1 - num2;
//Modulus
int mod = num1 % num2;

Console.WriteLine("*********MATH RESULTS*********");
Console.WriteLine("");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quoteint: {quoteint}");
Console.WriteLine($"Deference: {deference}");
Console.WriteLine($"Mod: {mod}");
Console.WriteLine("");
Console.WriteLine("*********END MATH RESULTS*********");

/*
 * Logic operators and Operators
 */
bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanorEqualTo = num1 >= num2;
bool isLessThanorEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("*********LOGIC RESULTS*********");

Console.WriteLine($"Is Greater Than {isGreaterThan}");
Console.WriteLine($"Is Less Than {isLessThan}");
Console.WriteLine($"Is Equal To {isEqualTo}");
Console.WriteLine($"Is greater than or Equal To {isGreaterThanorEqualTo}");
Console.WriteLine($"Is less Than of Equal To {isLessThanorEqualTo}");
Console.WriteLine($"Is not Equal To {isNotEqualTo}");
Console.WriteLine("*********END LOGIC RESULTS*********");

/*
 * Assignment Operations and Operators
 */
//int randomValue = 6;
//int increseValue = num1 + 5;

//num1 = num1 + 5;
//num1 += 5;
//num1 -= 3;
//num1 /= 2;
//num1 %= 2;
//num1 *= 10;

Console.WriteLine("Enter Random Value for Assignment Operator: ");
int randomValue = Convert.ToInt32(Console.ReadLine());
//int increaseValue = num1 + randomValue

Console.WriteLine("****** Assignment results *****");
Console.WriteLine("");
//num1 = num1 + randomValue;
num1 += randomValue;
Console.WriteLine($"Num 1 incresed by : {randomValue}: {num1}");
//num1 = num1 - randomValue;
num1 -= randomValue;
Console.WriteLine($"Num 1 is reduced by : {randomValue}: {num1}");
//num1 = num1 / randomValue;
num1 /= randomValue;
Console.WriteLine($"Num 1 is diveded by : {randomValue}: {num1}");
//num1 = num1 % rndomValue
num1 %= randomValue;
Console.WriteLine($"Num 1 is mod by : {randomValue}: {num1}");
//num1 = num1 * randomValue
num1 *= randomValue;
Console.WriteLine($"Num 1 is Multiplied by : {randomValue}: {num1}");
//Console.WriteLine("");
Console.WriteLine("*********END OF ASSIGNMENT RESULTS*********");



















