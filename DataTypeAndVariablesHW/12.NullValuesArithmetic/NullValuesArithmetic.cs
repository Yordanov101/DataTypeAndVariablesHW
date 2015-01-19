using System;
class NullValuesArithmetic
{
    //Create a program that assigns null values to an integer and to a double variable.
    // Try to print these variables at the console.
    // Try to add some number or the null literal to these variables and print the result.
    static void Main()
    {
        int? someVariableOne = null;
        double? someVariableTwo = null;
        Console.WriteLine("Nullable integer has value {0}",someVariableOne);
        Console.WriteLine("Nullable double has value {0}",someVariableTwo);
        someVariableOne = 6;
        someVariableTwo = 12.6d;
        Console.WriteLine("Integer with value is:{0}",someVariableOne);
        Console.WriteLine("Double with value is :{0}",someVariableTwo);
    }
}
