//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:
//n	        binary representation	    p	    bit # p
//5	        00000000 00000101	        2	    1
//0	        00000000 00000000	        9       0
//15	    00000000 00001111	        1	    1
//5343	    00010100 11011111	        7	    1
//62241	    11110011 00100001	        11	    0
using System;
class Bitwise
{
    static void Main()
    {
        Console.Write("n=");
        uint num = uint.Parse(Console.ReadLine());
        string binRepresntation = Convert.ToString(num, 2).PadLeft(32,'0');         //Creates string, containing the binary value of num
        Console.WriteLine(binRepresntation);                                        //binary representation
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numAndMask = (int)num & mask;
        int bit = numAndMask >> p;
        Console.WriteLine(bit);

    }
}