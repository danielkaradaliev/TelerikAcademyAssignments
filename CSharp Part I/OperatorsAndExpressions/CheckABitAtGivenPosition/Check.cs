//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:
//n	        binary representation of n	    p	    bit @ p == 1
//5	        00000000 00000101	            2	    true
//0	        00000000 00000000	            9	    false
//15	    00000000 00001111	            1	    true
//5343	    00010100 11011111	            7	    true
//62241	    11110011 00100001	            11	    false
using System;
class Bitwise
{
    static void Main()
    {
        bool flag;
        Console.Write("n=");
        int num = int.Parse(Console.ReadLine());
        string binRepresntation = Convert.ToString(num, 2).PadLeft(32,'0');         //Creates string, containing the binary value of num
        Console.WriteLine(binRepresntation);                                        //binary representation
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        if ((num & (1 << p)) >> p == 0)
            flag = false;
        else
            flag = true;
        Console.WriteLine(flag);

    }
}