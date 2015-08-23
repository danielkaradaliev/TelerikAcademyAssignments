//Problem 5. Maximal area sum
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:
//input	        output
//4             17
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2
using System;
using System.IO;
class MaximalAreaSum
{
    static int BestSum(int[,] matrix)
    {
        int CurrentSum = 0;
        int BestSum = 0;
        for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
            {
                CurrentSum = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        CurrentSum += matrix[row + i, col + j];
                    }
                }
                if (CurrentSum > BestSum)
                {
                    BestSum = CurrentSum;
                }
            }
        }
        return BestSum;
    }
    static void Main()
    {
        Console.WriteLine("Enter size of the matrix");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int[,] newMatrix = new int[N, N];
        StreamWriter InputFile = new StreamWriter("..//..//InputFile.txt");
        using (InputFile)
        {
            InputFile.WriteLine(N);
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write("Element [{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                    InputFile.Write(matrix[row, col] + " ");
                }
                InputFile.WriteLine();
            }
        }
        StreamReader AgainTheInputFile = new StreamReader("..//..//InputFile.txt");
        using (AgainTheInputFile)
        {
            string CurrentLine = AgainTheInputFile.ReadLine();
            int length = int.Parse(CurrentLine);
            CurrentLine = AgainTheInputFile.ReadLine();
            while (CurrentLine != null)
            {
                for (int p = 0; p < length; p++)
                {
                    for (int q = 0; q < length; q++)
                    {
                        string number = "";
                        for (int i = 0; i < CurrentLine.Length; i++)
                        {
                            if (CurrentLine[i] == ' ')
                            {
                                newMatrix[p, q] = int.Parse(number);
                                number = "";
                                q++;
                            }
                            else
                            {
                                number += CurrentLine[i];
                            }
                        }
                    }
                    CurrentLine = AgainTheInputFile.ReadLine();
                }
            }
        }
        StreamWriter OutputFile = new StreamWriter("..//..//OutputFile.txt");
        using (OutputFile)
        {
            OutputFile.WriteLine(BestSum(newMatrix));
        }
        Console.WriteLine("Done!");
    }
}