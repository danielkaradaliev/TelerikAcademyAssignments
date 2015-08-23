//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4: //I found it hard to paste them all here,sorry :|
using System;
class Matrix
{
    static void a(int x)
    {
        int br = 1;
        for (int row = 0; row < x; row++)
        {
            for (int col = 0; col < x; col++)
            {
                Console.Write("{0} ", br);
                br++;
            }
            Console.WriteLine();
        }
    }
    static void b(int x)
    {
        int[,] b = new int[x, x];
        int br = 1;
        for (int row = 0; row < x; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < x; col++)
                {
                    b[col, row] = br++;
                }
            }
            else
            {
                for (int col = x - 1; col >= 0; col--)
                {
                    b[col, row] = br++;
                }
            }
        }
        for (int row = 0; row < x; row++)
        {
            for (int col = 0; col < x; col++)
            {
                Console.Write("{0} ", b[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void c(int x)
    {
        int Row = x - 1;
        int Col = 0;
        int startRow = x - 1;
        int startCol = 0;
        int[,] c = new int[x,x];
        int br = 1;
        while (br < x * x)
        {
            if (Row == (x - 1) && Col < (x - 1))        //Filling matrix
            {
                if (br == 1)
                {
                    c[Col, Row] = br;
                }
                startRow--;
                startCol = 0;
                Row = startRow;
                Col = startCol;
                br++;
                c[Col, Row] = br;

                while (Row < (x - 1) && Col < (x - 1))
                {
                    Row++;
                    Col++;
                    br++;
                    c[Col, Row] = br;
                }
            }
            if (Row <= (x - 1) && Col == (x - 1))
            {
                startRow = 0;
                startCol++;
                Row = startRow;
                Col = startCol;
                br++;
                c[Col, Row] = br;

                while (Col < (x - 1))
                {
                    Col++;
                    Row++;
                    br++;
                    c[Col, Row] = br;
                }
            }
        }
        for (int i = 0; i < x; i++)           
        {
            for (int r = 0; r < x; r++)
            {
                Console.Write("{0} ", c[r, i]);
            }
            Console.WriteLine();
        }
        br = 1;
        Console.WriteLine();
    }
    static void d(int x)
    {
        int maxValue = x * x;
        int[,] d = new int[x, x];
        int row = 0;
        int column = 0;
        int counter = 1;
        int side = x;

        while (counter <= maxValue)
        {
            for (int i = 0; i < side; i++)
            {
                d[row, column] = counter;
                counter++;
                column++;
            }
            row++;                        
            side--;                       
            column--;
            for (int i = 0; i < side; i++)
            {
                d[row, column] = counter;
                counter++;
                row++;
            }
            column--;                     
            row--;
            for (int i = 0; i < side; i++)
            {
                d[row, column] = counter;
                counter++;
                column--;
            }
            row--;                        
            column++;
            side--;                       
            for (int i = 0; i < side; i++)
            {
                d[row, column] = counter;
                counter++;
                row--;
            }
            column++;                     
            row++;
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("{0} ", d[i, j]);
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("a)");
        Console.WriteLine();
        a(n);
        Console.WriteLine();
        Console.WriteLine("b)");
        Console.WriteLine();
        b(n);
        Console.WriteLine();
        Console.WriteLine("c)");
        Console.WriteLine();
        c(n);
        Console.WriteLine();
        Console.WriteLine("d)");
        Console.WriteLine();
        d(n);
    }
}