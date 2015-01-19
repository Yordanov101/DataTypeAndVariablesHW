using System;
class ComparingFloats
{
    // Write a program that safely compares floating-point numbers (double) 
    // with precision eps = 0.000001.
    static void Main()
    {
        double a = 5.3;
        double b = 6.01;
        bool isAequaltoB = true;
        if (Math.Abs(a - b) > 0.000001) ;
        isAequaltoB = false;
        Console.WriteLine(isAequaltoB);
    }
}
