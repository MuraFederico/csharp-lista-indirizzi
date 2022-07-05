
using csharp_lista_indirizzi;
using Microsoft.VisualBasic.FileIO;

StreamReader addresses = File.OpenText("C:/boolean/classe 56/.Net/csharp-lista-indirizzi/addresses.csv");

addresses.ReadLine();

TextFieldParser parser = new TextFieldParser(addresses);

parser.HasFieldsEnclosedInQuotes = true;
parser.SetDelimiters(",");

List<Address> addressesList = new List<Address>();
List<string> corruptedLines = new List<string>();

while (!parser.EndOfData)
{
    string address = addresses.ReadLine();
    string[] arrFields = parser.ReadFields();
    try
    { 
        string name = arrFields[0];
        string surname = arrFields[1];
        string street = arrFields[2];
        string city = arrFields[3];
        string province = arrFields[4];
        int zIP = int.Parse(arrFields[5]);

        Address newAddress = new Address(name, surname, street, city, province, zIP);

        addressesList.Add(newAddress);
    }catch(IndexOutOfRangeException e)
    {
        string str = "";
        foreach(string field in arrFields)
        {
            str = str + field + ",";
        }
        corruptedLines.Add(str);
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
    StreamWriter file = File.AppendText("C:/boolean/classe 56/.Net/csharp-lista-indirizzi/log corrupted.txt");

    foreach (string line in corruptedLines)
    {
        file.WriteLine(line);
    }

    file.Close();
    Console.WriteLine("#############");
    Console.WriteLine("# ATTENTION #");
    Console.WriteLine("#############\n");
    Console.WriteLine($"{corruptedLines.Count()} addresses where corrupted, therfore not transcripted to the formatted file, see corrupte log for details");
}
