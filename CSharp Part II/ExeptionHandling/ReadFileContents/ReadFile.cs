//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.IO;
class ReadFile
{
    static void Main()
    {
        Console.WriteLine("Enter the path to the file: ");
        string FileLocation = Console.ReadLine();
        try
        {
            Console.WriteLine(File.ReadAllText(FileLocation));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path or file name");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access Denied!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
        }
        
    }
}