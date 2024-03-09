// See https://aka.ms/new-console-template for more information
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

using System.Transactions;

Console.WriteLine("Please enter your birthday!(MMDDYY)");
DateTime birthday = DateTime.Parse(Console.ReadLine());

int age = AgeCalculator(birthday);
Console.WriteLine("Your age is:" + age);


static int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;

    if (birthday > today.AddYears(-age))
    {
       age--;
    }
    return age;
}