using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStories = 0;
            string resultString = "";

            string templateFile = "C:\\Users\\Jack\\Desktop\\IGME 201\\PE-7 - Mad Libs\\MadLibsTemplate.txt";

            StreamReader reader = File.OpenText(templateFile);

            string[] allLines = File.ReadAllLines(templateFile);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                numStories++;
            }

            string yourName;
            int chosenStory;
            Console.WriteLine("Enter your name: ");
            yourName = Console.ReadLine();
            Console.WriteLine("Choose a story 1 - " + (numStories-1));
            chosenStory = Int32.Parse(Console.ReadLine());

            string[] words = allLines[chosenStory].Split(' ');

            for (int j = 0; j < words.Length; j++)
            {
                //char[] word = words[j].ToCharArray();

                if (words[j].Contains("{"))
                {
                    string outputWord = words[j];

                    outputWord = outputWord.Replace('{', ' ');
                    outputWord = outputWord.Replace('}', ' ');
                    outputWord = outputWord.Replace('_', ' ');

                    Console.WriteLine("Enter a(n)" + outputWord + ": ");
                    string input = Console.ReadLine();

                    resultString += (" " + input);
                }
                else if (words[j].Contains("\\"))
                {
                    resultString += (" \r\n");
                }
                else
                {
                    resultString += (" " + words[j]);
                }
            }

            Console.WriteLine(resultString);
            
        }
    }
}
