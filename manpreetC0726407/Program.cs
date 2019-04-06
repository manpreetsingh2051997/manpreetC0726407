
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList  Beowulf;
        private int countletters;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Wordskipper();
            Console.ReadLine();
        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            // Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/726407/Downloads"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;

                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                Console.WriteLine($"File has {counter * 10} words.");


            }
        }
        public void Wordfinder()
        {
            int f = 0;
            foreach (var line in File.ReadAllLines("U:/Users/726407/Downloads"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    f++;
                }
            }
            Console.WriteLine(f);
        }
        public void Wordskipper()
        {
            int f = 0;
            foreach (var line in File.ReadAllLines("U:/Users/726407/Downloads"))
            {
                f++;
                if (line.Contains("fare") && (!line.Contains("war")))
                {
                    Console.WriteLine(f);
                }

            }
        }

        public int FindNumberOfBlankSpaces(string line)
        {
            // hhtp://stackovrflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
            int countletter = 0;
            int countSpaces = 0;
            foreach (char c in line)

            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }

            }
            return countSpaces;
        }
    }
}

