
StreamReader addresses = File.OpenText("C:/boolean/classe 56/.Net/csharp-lista-indirizzi/addresses.csv");

string  fields = addresses.ReadLine();
Console.WriteLine(fields);