﻿//Problem 4. Print a Deck of 52 Cards
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output
//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds
//Note: You may use the suit symbols instead of text.
using System;
class Deck
{
    static void Main()
    {
        char[] colors = { '♠', '♣', '♦', '♥' };
        char? currentChar = null;

        for (int card = 2; card <= 15; card++)
        {
            for (int colorIndex = 0; colorIndex < 4; colorIndex++)
            {
                currentChar = colors[colorIndex];
                switch (card)
                {
                    case 11:
                        break;
                    case 12:
                        Console.Write("J{0} ", currentChar);
                        break;
                    case 13:
                        Console.Write("D{0} ", currentChar);
                        break;
                    case 14:
                        Console.Write("K{0} ", currentChar);
                        break;
                    case 15:
                        Console.Write("A{0} ", currentChar);
                        break;
                    default:
                        Console.Write("{0}{1} ", card, currentChar);
                        break;
                }

            }
            if (card != 11)
            {
                Console.WriteLine();
            }
        }
    }
}