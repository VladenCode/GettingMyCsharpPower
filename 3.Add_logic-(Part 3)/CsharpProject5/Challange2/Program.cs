/*
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
*/

/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/

// Challange 1
//-----------------------------------------------------------------

/*
string? readResult;
Console.WriteLine("Input a number between 5 and 10:");
int numericValue = 0;
bool validEntry = false;

do
{
  readResult = Console.ReadLine();
  int.TryParse(readResult, out numericValue);

  if (!string.IsNullOrEmpty(readResult))
  {
    if(numericValue < 5 || numericValue > 10)
    {
      Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
      continue;
    }
    validEntry = true; 
  } 
  else
  { 
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
  }
}while(validEntry == false);

Console.WriteLine($"Your input value {numericValue} has been accepted.");
*/

//Solution 1

/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

// Challange 2
//-----------------------------------------------------------------

/*
Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
string? readResult;
bool validEntry = false;

do
{
  readResult = Console.ReadLine();
  if(!string.IsNullOrEmpty(readResult))
  {
    switch(readResult.Trim().ToLower())
    {
      case "administrator":
      case "manager":
      case "user":
      Console.WriteLine($"Your input value ({readResult}) has been accepted.");
      validEntry = true;
      break;
      default:
      Console.WriteLine($"The role name that you entered, {readResult} is not valid. Enter your role name (Administrator, Manager, or User)");
      break;
    }
  }
  else
  { 
    Console.WriteLine("Sorry, you entered an invalid input, please try again");
  }
}while(validEntry == false);
*/

//Solution 2

/*
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/

// Challange 3
//-----------------------------------------------------------------
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string myString = "";
string currentString = "";

foreach(string strElement in myStrings) {
  periodLocation = strElement.IndexOf(".");
  myString = strElement;

  while(periodLocation != -1) 
  {
    currentString = myString.Remove(periodLocation);

    myString = myString.Substring(periodLocation + 1).Trim();

    periodLocation = myString.IndexOf(".");

    Console.WriteLine(currentString);
  }
    Console.WriteLine(myString);
}
*/


// Solution 3
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/


