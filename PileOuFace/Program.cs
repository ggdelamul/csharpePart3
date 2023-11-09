Random random = new Random ();
string result = random.Next(1,3) >1 ? "Pile" : "Face";
Console.WriteLine(result);