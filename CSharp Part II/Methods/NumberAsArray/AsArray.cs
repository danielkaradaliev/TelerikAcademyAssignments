//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Text;
class AsArray
{
    static string SumTwoNumbers(string num1, string num2)
    {
        int[] arr1 = new int[Math.Max(num1.Length, num2.Length)];
        int[] arr2 = new int[Math.Max(num1.Length, num2.Length)];
        int[] arr3 = new int[Math.Max(num1.Length, num2.Length) + 1];

        StringBuilder sb = new StringBuilder();

        sb.Append(num1);
        for (int i = 0; i < num1.Length; i++)
        {
            arr1[i] = Convert.ToInt32(sb[num1.Length - 1 - i].ToString());
        }

        sb.Clear();
        sb.Append(num2);
        for (int i = 0; i < num2.Length; i++)
        {
            arr2[i] = Convert.ToInt32(sb[num2.Length - 1 - i].ToString());
        }

        sb.Clear();
        int number = 0;
        for (int i = 0; i < Math.Max(num1.Length, num2.Length) + 1; i++)
        {
            if (i == 0)
            {
                arr3[i] = (arr1[i] + arr2[i]) % 10;
            }
            else if (i == Math.Max(num1.Length, num2.Length))
            {
                arr3[i] = (arr1[i - 1] + arr2[i - 1]) / 10;
            }
            else
            {
                arr3[i] = (arr1[i] + arr2[i]) % 10 + (arr1[i - 1] + arr2[i - 1]) / 10 + number;
                number = 0;
                if (arr3[i] > 9)
                {
                    number = arr3[i] / 10;
                    arr3[i] = arr3[i] % 10;
                }
            }
        }

        Array.Reverse(arr3);
        if (arr3[0] != 0)
        {
            sb.Append(arr3[0]);
        }
        for (int i = 1; i < Math.Max(num1.Length, num2.Length) + 1; i++)
        {
            sb.Append(arr3[i]);
        }
        return sb.ToString();
    }
    static void Main()
    {
        
            Console.WriteLine("Enter two numbers:");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string result = SumTwoNumbers(num1, num2);
            Console.WriteLine(result);
    }
}