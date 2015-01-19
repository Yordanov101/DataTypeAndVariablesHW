using System;
class IsoscelesTriangle
{
    // Write a program that prints an isosceles triangle of 9 copyright symbols ©.
    static void Main()
    {
        char copyrightSign = '\u00A9';
        Console.WriteLine("    {0}",copyrightSign);
        Console.WriteLine();
        Console.WriteLine("   {0} {0}",copyrightSign);
        Console.WriteLine();
        Console.WriteLine("  {0}   {0}",copyrightSign);
        Console.WriteLine();
        Console.WriteLine(" {0} {0} {0} {0}",copyrightSign);
    }
}