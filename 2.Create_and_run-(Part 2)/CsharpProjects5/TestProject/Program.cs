// Declaring array of strings
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/

// fraudulentOrderIDs[3] = "D000";

// Initializing an array of string
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//forseach method for looping
foreach(string id in fraudulentOrderIDs){
  Console.WriteLine($"emelent: {id}");
}


// Initialize an array of int

int bin = 0;
int sum = 0;
int[] inventory = { 200, 450, 700, 175, 250 };

foreach (int items in inventory) {
  bin++;
  sum += items;
  Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

}

Console.WriteLine($"We have {sum} items in inventory.");