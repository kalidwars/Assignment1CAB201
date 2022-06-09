using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;



public class seventhlevel
{
    public static void level7(string[] args)
    {
        string line;
        string query = args[3].Replace("*", ".*");
        StreamReader file = new System.IO.StreamReader(args[2]);
        string prevLine = "";
        var i = false;
        args[2] = "16S.fasta";


        Regex q = new Regex(@query);

        while ((line = file.ReadLine()) != null)
        {
            if (args.Length != 4)
            {

                Console.WriteLine("Error. Number of arguments input is incorrect, must be 4 arguments. \n");
                Console.WriteLine("Correct example input: Search16s  -level7  16S.fasta ACTG*GTAC*CA");
                return;
            }

            if (!File.Exists(args[2]))
            {
                Console.WriteLine("Error. Input file not found.\n");
                Console.WriteLine("Correct file input: 16S.fasta");
                return;

            }

            Match match = q.Match(line);
            // If there is more than 1 id in the line, they will all be split up and printed out.

            if (line.Contains(">"))
            {
                //Console.WriteLine(i+" "+s);
                prevLine = line;
                i = true;

            }
            else if (match.Success)
            {
                Console.WriteLine(prevLine.Substring(1, 12));
            }
                       
        }

        if (i)
        {
            i = false;
            Console.WriteLine("Error. Sequence wild card word not found. \n");
            Console.WriteLine("Correct example input: ACTG*GTAC*CA");

        }


    }
}



