/*string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);*/

  int userInput;
            bool isValidNumber = false;

            // Prompt the user for an integer value between 5 and 10
            Console.WriteLine("Enter an integer value between 5 and 10");

            // Use a do-while loop to repeatedly prompt for input until a valid integer between 5 and 10 is entered
            do
            {
                // Read the user input
                string? input = Console.ReadLine();

                // Check if the input is a valid integer
                if (int.TryParse(input, out userInput))
                {
                    // Check if the integer is within the range of 5 and 10
                    if (userInput >= 5 && userInput <= 10)
                    {
                        isValidNumber = true;
                        // Inform the user when a valid input is entered
                        Console.WriteLine($"Your input value ({userInput}) has been accepted.");
                    }
                    else
                    {
                        // Prompt the user to enter a number between 5 and 10
                        Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    // Inform the user that the input is not a valid number
                    Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                }
            }
            while (!isValidNumber);
