using System;
class StringAndObjects
{
    // Declare two string variables and assign them with "Hello" and "World".
    //Declare an object variable and assign it with the concatenation of the first two variables.
    // Declare a third string variable and initialize it with the value of the object variable.
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object greeting = firstWord +" "+ secondWord ;
        string message = (string) greeting;
        Console.WriteLine(message);
    }
}