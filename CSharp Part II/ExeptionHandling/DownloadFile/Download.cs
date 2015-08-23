//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.IO;
using System.Net;
class Download
{
    static void Main()
    {
        Uri fileUrl;
        string FileName = "";
        string path = Directory.GetCurrentDirectory();
        Console.WriteLine("Enter url to the file:");
        try
        {
            string fullName = Console.ReadLine();
            FileName = fullName.Substring(fullName.LastIndexOf('/'), fullName.Length - fullName.LastIndexOf('/'));
            fileUrl = new Uri(fullName);
        }
        catch
        {
            Console.WriteLine("Invalid URL!");
            return;
        }
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile(fileUrl, path + "\\" + FileName);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Detected Null value!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Not supported!");
            }
            catch (WebException)
            {
                Console.WriteLine("Url not found!");
            }
            finally
            {
                Console.WriteLine("File downloaded successfully!");
            }
        }
    }
}