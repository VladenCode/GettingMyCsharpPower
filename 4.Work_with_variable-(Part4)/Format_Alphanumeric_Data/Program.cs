//COmposite Formating

/*
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result); // Hello World!
*/

/*
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second); //World Hello!
Console.WriteLine("{0} {0} {0}!", first, second); //Hello Hello Hello!
*/

//Sting interpolation

/*
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!"); //Hello World!
Console.WriteLine($"{second} {first}!"); //World Hello!
Console.WriteLine($"{first} {first} {first}!"); //Hello Hello Hello!
*/

//Formating curency

/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
*/

//Formating numbers
/*
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
*/

//Formatting percentages

/*
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
*/

//Combine approaches

/*
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
*/

//EXERCISE (string interpolation)

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Product shares: {productShares:N3}");
Console.WriteLine($"\tSub Total: {subtotal:C}");
Console.WriteLine($"\tTax: {taxPercentage:P2}");
Console.WriteLine($"\n\t\tTotal bill: {total:C}\n");