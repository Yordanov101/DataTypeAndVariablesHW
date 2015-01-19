using System;
class VariableInHexadecimal
{
    // Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
    static void Main()
    {
        int numberInHex = 0xFE;
        Console.WriteLine("The decimal value of 0xFE is " + Convert.ToString(numberInHex,10));    
    }
}
