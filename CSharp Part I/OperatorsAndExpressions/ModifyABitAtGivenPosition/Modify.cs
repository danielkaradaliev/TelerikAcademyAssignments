//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
//Examples:
//n	        binary representation of n	    p	    v	    binary result	    result
//5	        00000000 00000101	            2	    0	    00000000 00000001	1
//0	        00000000 00000000	            9	    1	    00000010 00000000	512
//15	    00000000 00001111	            1	    1	    00000000 00001111	15
//5343	    00010100 11011111	            7	    0	    00010100 01011111	5215
//62241	    11110011 00100001	            11	    0	    11110011 00100001	62241
using System;
class Check
{
    static void Main()
    {
        int mask, numAndMask;
        Console.Write("n=");
        int num = int.Parse(Console.ReadLine());
        string binRepresntation1 = Convert.ToString(num, 2).PadLeft(32,'0');         //Creates string, containing the binary value of num
        Console.WriteLine(binRepresntation1);                                        //binary representation
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v=");
        int v = int.Parse(Console.ReadLine());
        if(v ==0)
        {
            mask = ~(1 << p);
            numAndMask = num & mask;
        }
        else
        {
            mask = 1 << p;
            numAndMask = num | mask;
        }
        string binRepresntation2 = Convert.ToString(numAndMask, 2).PadLeft(32,'0');         //Creates string, containing the binary value of num
        Console.WriteLine(binRepresntation2);                                               //binary representation
        Console.WriteLine(numAndMask);
    }
}