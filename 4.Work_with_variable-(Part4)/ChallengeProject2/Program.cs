string pangram = "The quick brown fox jumps over the lazy dog";
//expected output: ehT kciuq nworb xof spmuj revo eht yzal god

string[] arrayOfStrings = pangram.Split(' ');
char[] arrayElement = new char[0];
string[] arrayReversed = new string[0];

for(int i = 0; i < arrayOfStrings.Length; i++)
{
  arrayElement = arrayOfStrings[i].ToCharArray();
  Array.Reverse(arrayElement);
  arrayOfStrings[i] =  string.Join("", arrayElement);
}

string reversedString = string.Join(" ", arrayOfStrings);
Console.WriteLine(reversedString);