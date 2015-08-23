using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Program
    {
        static void Highscores(int score)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Dictionary<string, int> Highscore = new Dictionary<string, int>();
            using (StreamReader HighscoreFile = new StreamReader("..//..//Highscore.txt"))
            {
                bool check = false;
                int currentline = 1;
                string ReadName = "";
                int ReadScore = 0;
                string currentlinetext = "";
                while ((currentlinetext = HighscoreFile.ReadLine()) != null)
                {

                    if (currentline % 2 == 1)
                    {
                        ReadName = currentlinetext;
                        currentline++;
                    }
                    else if (currentline % 2 == 0)
                    {
                        ReadScore = int.Parse(currentlinetext);
                        currentline++;
                        check = true;
                    }
                    if (check)
                    {
                        Highscore.Add(ReadName, ReadScore);
                        ReadName = "";
                        ReadScore = 0;
                        check = false;
                    }
                }
                Highscore.Add(name, score);
                var sortedDict = from entry in Highscore orderby entry.Value descending select entry;
                var min = sortedDict.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
                Console.WriteLine(min);
                // foreach (KeyValuePair<string, int> pair in sortedDict)
                // {
                //     Console.WriteLine("{0}. !{1}! !{2}!", pair.Key, pair.Value);
                // }
            }
        }
        static void Main()
        {
            int score = 45;
            Highscores(score);
        }
    }
}
