// See https://aka.ms/new-console-template for more information
//Create a method that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

//The string must contain an @ character.
//The string must contain a . character.
//The @ must have at least one character in front of it.
//ex. "e@mail.com" is valid, while "@email.com" is invalid.
//The . and the @ must be in the appropriate places.
//ex. "hello.email@com" is invalid while "john.smith@email.com" is valid.
//If the string passes these tests, it's considered a valid email address.

//Examples:
//ValidateEmail("@gmail.com") ➞ false

//ValidateEmail("hello.gmail@com") ➞ false

//ValidateEmail("gmail") ➞ false

//ValidateEmail("hello@gmail") ➞ false

//ValidateEmail("hello@gmail.com") ➞ true

using System.Runtime.InteropServices;




Console.WriteLine("Please enter your email address: ");
string email = Console.ReadLine();

bool isValid = ValidateEmail(email);
if (!isValid)
{
    Console.WriteLine("The email you enterd is not valid " + email);
}
else {
    Console.WriteLine("The email you enterd is valid " + email);
}



static bool ValidateEmail(string email)
{
    if (!email.Contains("@"))
    {
        return false;
    }

    string[] parts = email.Split('@');
    if (parts.Length != 2)
    {
        return false;
    }

    string firstPart = parts[0];
    string secondPart = parts[1];

    if (firstPart.Length < 1)
    {
        return false;
    }

    if (!secondPart.Contains("."))
    {
        return false;
    }

    if(email.IndexOf('@') > email.LastIndexOf('.'))
    {
        return false;
    }
    
    if (secondPart.EndsWith("."))
    {
        return false;
    }

    return true;
}