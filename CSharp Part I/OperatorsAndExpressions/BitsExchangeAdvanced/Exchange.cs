//Problem 16.** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:
//n	                p	q	k	            binary representation of n	                        binary result	                result
//1140867093	    3	24	3	        01000100 00000000 01000000 00010101	            01000010 00000000 01000000 00100101	    1107312677
//4294901775	    24	3	3	        11111111 11111111 00000000 00001111	            11111001 11111111 00000000 00111111	    4194238527
//2369124121	    2	22	10	        10001101 00110101 11110111 00011001	            01110001 10110101 11111000 11010001	    1907751121
//987654321	        2	8	11	        00111010 11011110 01101000 10110001	                            -	                    overlapping
//123456789	        26	0	7	        00000111 01011011 11001101 00010101	                            -	                    out of range
//33333333333	   -1	0	33	        00000111 11000010 11010010 01001101 01010101	                -	                    out of range
using System;
using System.Collections.Generic;

class Exchange
{
    static void Main()
    {
        int i;
        uint number;
        Console.Write("n=");                                                        //Type n as a string
        string n = Console.ReadLine();
        uint num;
        bool result = (uint.TryParse(n, out number));                               // If n is out of the range of the unsigned int    
        if (result)
        {
            num = Convert.ToUInt32(n);                                              //Successful convertion
        }
        else
        {
            Console.WriteLine("out of range");                                      //Unsuccessful convertion
            return;
        }
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q=");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        string binRepresntation1 = Convert.ToString(num, 2).PadLeft(32, '0');         //Creates string, containing the binary value of num
        Console.WriteLine(binRepresntation1);                                         //binary representation
        int mask, mask2;
        int a = Math.Abs((p + k - 1) - (q + k - 1));
        if (p < q && q < p + k - 1)
        {
            Console.WriteLine("overlapping");
            return;
        }
        else if (p < 0 || p > 31 || q < 0 || q > 31 || (p + k - 1) < 0 || (p + k - 1) > 31 || (q + k - 1) < 0 || (q + k - 1) > 31)
        {
            Console.WriteLine("out of range");
            return;
        }
        if (p < q)
        {
            for (i = p; i <= p + k - 1; i++)
            {
                uint tempNumb = (num >> i) & 1;
                uint tempNumb2 = (num >> i + a) & 1;
                if (tempNumb != tempNumb2)
                {
                    mask = 1 << i + a;
                    mask2 = 1 << i;
                    num = num ^ (uint)mask;
                    num = num ^ (uint)mask2;
                }
            }
        }
        else
        {
            for (i = p; i <= p + k - 1; i++)
            {
                uint tempNumb = (num >> i) & 1;
                uint tempNumb2 = (num >> i - a) & 1;
                if (tempNumb != tempNumb2)
                {
                    mask = 1 << i - a;
                    mask2 = 1 << i;
                    num = num ^ (uint)mask;
                    num = num ^ (uint)mask2;
                }
            }
        }
        string binRepresntation2 = Convert.ToString(num, 2).PadLeft(32, '0');         //Creates string, containing the binary value of num
        Console.WriteLine(binRepresntation2);                                         //binary representation
        Console.WriteLine(num);
    }
}