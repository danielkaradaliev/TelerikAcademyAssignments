//Problem 19.** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:
//
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7
using System;
class SpiralMatrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int maxValue = number * number;
        int[,] matrix = new int[number, number];
        int row = 0;
        int column = 0;
        int counter = 1;
        int side = number;

        while (counter <= maxValue)
        {
            for (int i = 0; i < side; i++)              //loop for adding in matrix uper horisontal row
            {
                matrix[row, column] = counter;
                counter++;
                column++;
            }
            row++;                                      //setting the position of the nex number
            side--;                                     //sets the length of side
            column--;
            for (int i = 0; i < side; i++)              //loop for adding in matrix right vertical row
            {
                matrix[row, column] = counter;
                counter++;
                row++;
            }
            column--;                                   //setting the position of the nex number
            row--;
            for (int i = 0; i < side; i++)              //loop for adding in matrix lower horisontal row
            {
                matrix[row, column] = counter;
                counter++;
                column--;
            }
            row--;                                      //setting the position of the nex number
            column++;
            side--;                                     //sets the length of side
            for (int i = 0; i < side; i++)              //loop for adding in matrix left vertical row
            {
                matrix[row, column] = counter;
                counter++;
                row--;
            }
            column++;                                   //setting the position of the nex number
            row++;
        }
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0} ",matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}