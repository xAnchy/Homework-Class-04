// See https://aka.ms/new-console-template for more information
//Write a method that formats a given date and time as a string in a specific format.
//Get the needed inputs from screen.
//Allowed formats: "MM/dd/yyyy", "MM/dd/yyyy hh:mm:ss", "dddd, dd MMMM yyyy HH:mm:ss", "MM.dd.yyyy"

//Bonus: Create separate method that validates whether the entered format is allowed

Console.WriteLine("PLease enter the day and time (yyyy-MM-dd HH:mm:ss)");
DateTime dateTime = DateTime.Parse(Console.ReadLine());


Console.WriteLine("Plese enter which format you would like: MM/dd/yyyy\", \"MM/dd/yyyy hh:mm:ss\", \"dddd, dd MMMM yyyy HH:mm:ss\", \"MM.dd.yyyy");
string format = Console.ReadLine(); 

if (!IsValidFormat(format))
{
    Console.WriteLine("Invalid format. Allowed formats are: \"MM/dd/yyyy\", \"MM/dd/yyyy hh:mm:ss\", \"dddd, dd MMMM yyyy HH:mm:ss\", \"MM.dd.yyyy\"");
    return;
}

string formattedDateTime = FormatDateTime(dateTime, format);
Console.WriteLine("Formatted date and time " + formattedDateTime);

static string FormatDateTime(DateTime dateTime, string format)
{
    return dateTime.ToString(format);
}

static bool IsValidFormat(string format)
{
    string[] allowedFormats = { "MM/dd/yyyy", "MM/dd/yyyy hh:mm:ss", "dddd, dd MMMM yyyy HH:mm:ss", "MM.dd.yyyy" };
    foreach (string allowedFormat in allowedFormats)
    {
        if (format == allowedFormat)
        {
            return true;
        }
    }

    return false;

}