// See https://aka.ms/new-console-template for more information
//Given a string, create a method to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
//Examples:
//ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

//ReverseCase("MANY THANKS") ➞ "many thanks"

//ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"

Console.WriteLine("Enter a word or a sentence");
string input = Console.ReadLine();  

string result = ReverseCase(input);
Console.WriteLine("This is the reversed method: " + result);

static string ReverseCase(string input)
{
    char[] characters = input.ToCharArray();

    for (int i = 0; i < characters.Length; i++)
    {
        if (char.IsLower(characters[i]))
        {
            characters[i] = char.ToUpper(characters[i]);
        }
        else if (char.IsUpper(characters[i]))
        {
            characters[i] = char.ToLower(characters[i]);
        }
    }
    return new string(characters);
}