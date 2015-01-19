using System;
class FloatOrDouble
{
    // Which of the following values can be assigned to a variable of type float and which to a variable
    // of type double:34.567839023, 12.345, 8923.1234857, 3456.091?
    static void Main()
    {
        float firstFloat = 12.345F;
        float secondFloat = 3456.091F;
        double firstDouble = 34.567839023;
        double secondDouble = 8923.1234857;
        Console.WriteLine("float firstFloat = " + firstFloat + "\nfloat secondFloat = " + secondFloat + 
            "\ndouble firstDouble = "+ firstDouble + "\ndouble secondDouble = " + secondDouble);
    }
}
