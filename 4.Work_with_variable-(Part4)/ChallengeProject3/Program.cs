string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
/*
Expected output:
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/

string[] arrayOfStrings = orderStream.Split(",");
Array.Sort(arrayOfStrings);

foreach(string element in arrayOfStrings)
{
  if(element.Length == 4)
  {
    Console.WriteLine(element);
  }
  else
  {
    Console.WriteLine($"{element}\t - Error");
  }
}
