string role = "Enter your role name (Administrator, Manager, or User";

Console.WriteLine($"{role}");
string roleName = "";
string? input; // Declare a variable to store the user's input
bool valid = false;
do
{
    input = Console.ReadLine();
    if (input != null)
    {
        roleName = input.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        valid = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (!valid);


Console.WriteLine($"Your input value ({roleName}) has been accepted.");
input = Console.ReadLine();
