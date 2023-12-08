Random coin = new Random();
int flip = coin.Next(1, 11);

string headsOrTails = flip >= 5 ? "heads" : "tails";

Console.WriteLine(headsOrTails);