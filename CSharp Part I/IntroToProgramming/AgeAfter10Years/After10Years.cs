//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
class After10Years
{
    static void Main()
    {
        string YourBirthDay;
        Console.WriteLine("Type your birthday (The format is:dd.mm.year)");
        YourBirthDay = Console.ReadLine();
        string[] splitInput = YourBirthDay.Split(new Char[] { ' ', '.', ':', '\\', '/' }); //Other splitters in case the user didn't get it :D
        Console.WriteLine(YourBirthDay);
        int[] InputDate = Array.ConvertAll<string, int>(splitInput, int.Parse); //Converts the inputed string into an array
        if (                                                                    //Checking id the typed date is valid
            (InputDate[1] == 1 && (InputDate[0] < 1 || InputDate[0] > 31)) || //January
            ((InputDate[1] == 2) && (((InputDate[2] % 4 != 0) && ((InputDate[1] == 2) && (InputDate[0] < 1 || InputDate[0] > 28))) || ((InputDate[2] % 4 == 0) && ((InputDate[1] == 2) && (InputDate[0] < 1 || InputDate[0] > 29))))) || //February
            (InputDate[1] == 3 && (InputDate[0] < 1 || InputDate[0] > 31)) || //March
            (InputDate[1] == 4 && (InputDate[0] < 1 || InputDate[0] > 30)) || //April
            (InputDate[1] == 5 && (InputDate[0] < 1 || InputDate[0] > 31)) || //May
            (InputDate[1] == 6 && (InputDate[0] < 1 || InputDate[0] > 30)) || //June
            (InputDate[1] == 7 && (InputDate[0] < 1 || InputDate[0] > 31)) || //July
            (InputDate[1] == 8 && (InputDate[0] < 1 || InputDate[0] > 31)) || //August
            (InputDate[1] == 9 && (InputDate[0] < 1 || InputDate[0] > 30)) || //September
            (InputDate[1] == 10 && (InputDate[0] < 1 || InputDate[0] > 31)) || //October
            (InputDate[1] == 11 && (InputDate[0] < 1 || InputDate[0] > 30)) || //November
            (InputDate[1] == 12 && (InputDate[0] < 1 || InputDate[0] > 31)) || //December
            (InputDate[1] < 1 || InputDate[1] > 12) || //Cheking the month only
            (InputDate[2] < 1900 || InputDate[2] > 2100) //Checking for the year
          )
        {
            Console.WriteLine("Invalid date!");
            return;
        }

        string CompDate = DateTime.Now.ToString("dd.MM.yyyy"); //Gets the current time into a string
        string[] splitSysDate = CompDate.Split('.');
        int[] SysDate = Array.ConvertAll<string, int>(splitSysDate, int.Parse); //Converts the string into an array
        if ((SysDate[2] < InputDate[2]) || ((SysDate[2] == InputDate[2]) && (SysDate[1] < InputDate[1])) || ((SysDate[2] == InputDate[2]) && (SysDate[1] == InputDate[1]) && (SysDate[0] < InputDate[0]))) //Checks if the user typed a date that is yet to come
        {
            Console.WriteLine("Hey, you aren't born yet!!!");
        }
        if ((SysDate[2] == InputDate[2]) && (SysDate[1] == InputDate[1]) && (SysDate[0] == InputDate[0])) //If the user typed the current date
        {
            Console.WriteLine("Hey, you have just been borned! You must be very clever if you have already learned to use a computer!");
        }
        if ((SysDate[2] > InputDate[2]) && (SysDate[1] == InputDate[1]) && (SysDate[0] == InputDate[0]))
        {
            int year1 = SysDate[2] - InputDate[2];
            Console.WriteLine("Today is your birthday! Happy birthday!");
            Console.WriteLine("You turn {0} year(s) today", year1);
            year1 = year1 + 10;
            Console.WriteLine("After 10 years you will be {0} years old!", year1);
        }
        if ((SysDate[2] > InputDate[2]) || ((SysDate[2] == InputDate[2]) && (SysDate[1] > InputDate[1])) || ((SysDate[2] == InputDate[2]) && (SysDate[1] == InputDate[1]) && (SysDate[0] > InputDate[0])))
        {
            int year2;
            if ((SysDate[1] < InputDate[1]) || ((SysDate[1] == InputDate[1]) && (SysDate[0] < InputDate[0])))
            {
                year2=SysDate[2] - InputDate[2]-1;
                Console.WriteLine("Today you are {0} year(s) old!", year2);
                year2 = year2 + 10;
                Console.WriteLine("After 10 years you will be {0} years old!", year2);
            }
            else
            {
                year2 = SysDate[2] - InputDate[2];
                Console.WriteLine("Today you are {0} year(s) old!", year2);
                year2 = year2 + 10;
                Console.WriteLine("After 10 years you will be {0} years old!", year2);
            }

        }
        Console.ReadLine();
    }
}
