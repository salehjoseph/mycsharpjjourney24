string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    string corp = "@contoso.com";
    string firstName =  corporate[i,0];
    string lastName = corporate[i,1];
    // display internal email addresses
   
    string email = firstName.Substring(0,2) + lastName +corp;
    Console.WriteLine(email.ToLower());
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    string firstName = external[i,0];
    string lastName = external[i,1];

    string email = firstName.Substring(0,2) + lastName + externalDomain;
    Console.WriteLine(email.ToLower());
}