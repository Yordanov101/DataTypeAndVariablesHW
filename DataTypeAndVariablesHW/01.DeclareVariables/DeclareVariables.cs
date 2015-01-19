using System;
class DeclareVariables
{
    // Declare five variables choosing for each of them the most appropriate of the types byte,sbyte,
    //short,ushort,int,uint,long,ulong to represent the following values:52130,-115, 4825932, 97,-10000.
    static void Main()
    {
        ushort firstVar = 52130;
        sbyte  secondVar = -115;
        int thridVar = 4825932;
        byte fourthVar = 97;
        short fifthVar = -10000;
        Console.WriteLine("ushort firstVar = "+firstVar+"\nsbyte secondVar = "+secondVar+"\nint thirdVar = "
            +thridVar+"\nbyte fourthVar = "+fourthVar+"\nshort fifthVar = "+fifthVar);


    }
}
