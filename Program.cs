
using csharp_lista_indirizzi;

StreamReader addresses = File.OpenText("C:/boolean/classe 56/.Net/csharp-lista-indirizzi/addresses.csv");

string  fields = addresses.ReadLine();
/*Console.WriteLine(fields);*/

List<Address> addressesList = new List<Address>();
List<string> corruptedLines = new List<string>();

while (!addresses.EndOfStream)
{
    string address = addresses.ReadLine();
    string[] arrFields = address.Split(",");
    try
    { 
        string name = arrFields[0];
        string surname = arrFields[1];
        string street = arrFields[2];
        string city = arrFields[3];
        string province = arrFields[4];
        int zIP;
        try
        {
            zIP = int.Parse(arrFields[5]);
        }
        catch (FormatException e)
        {
            zIP = 0;
        }
        Address newAddress = new Address(name, surname, street, city, province, zIP);

        addressesList.Add(newAddress);
    }catch(IndexOutOfRangeException e)
    {
        corruptedLines.Add(address);
    }
}

addresses.Close();

string path = "C:/boolean/classe 56/.Net/csharp-lista-indirizzi/formatted addresses.txt";
if (!File.Exists(path))
{

    StreamWriter file = File.CreateText(path);

    foreach (Address address in addressesList)
    {
        file.WriteLine(address.ToString());
    }

    file.Close();
}

if(corruptedLines.Count > 0)
{
    Console.WriteLine("#############");
    Console.WriteLine("# ATTENTION #");
    Console.WriteLine("#############\n");
    Console.WriteLine($"{corruptedLines.Count()} addresses where corrupted, therfore not transcripted to the formatted file");
}
