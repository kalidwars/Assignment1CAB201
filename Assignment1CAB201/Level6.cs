using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


public class sixthlevel
{
    public static void level6(string[] args)
    {
        string line;
        StreamReader file = new System.IO.StreamReader(args[2]);
        string prevLine = "";
        var i = false;
        args[2] = "16S.fasta";

        while ((line = file.ReadLine()) != null)
        {
            if (args.Length != 4)
            {

                Console.WriteLine("Error. Number of arguments input is incorrect, must be 4 arguments.");
                Console.WriteLine("Correct example input: Search16s  -level5  16S.fasta Streptomyces");

                return;
            }

            if (!File.Exists(args[2]))
            {
                Console.WriteLine("Error. Input file not found.");
                Console.WriteLine("Correct file input: 16S.fasta");
                return;

            }

            if (line.Contains(">"))
            {
                
                prevLine = line;
                i = true;

            }
           

            if (line.Contains(args[3]))
            {
                Console.WriteLine(prevLine.Substring(1, 12));
            }
        }

        if (i)
        {
            i = false;
            Console.WriteLine("Error. Sequence meta-data word not found. \n");
            Console.WriteLine("Correct example input: Streptomyces");

        }
    }
}

