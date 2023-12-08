string[] fraudulentOrderId = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(string letter in fraudulentOrderId){
  if(letter[0] == 'B'){
    Console.WriteLine($"Fraud stuff: {letter}");
  }
}

