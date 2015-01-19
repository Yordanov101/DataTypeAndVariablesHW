using System;
class UnicodeCharacter
{
    // Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal)
    // using the \u00XX syntax, and then print it.
    static void Main()
    {
        char symbol = '\u002A';
        Console.WriteLine("The character of \"u002A\" with Unicode code 42(decimal) is " +symbol);

    }
}
