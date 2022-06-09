using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Assignment1CAB201
{
    static void Main(string[] args)

    {
        /*if (args[0] == "-level1")
        {
            firstlevel.level1(args);
            Console.Read();
            return;
        }
        else if (args[0] == "-level2")
        {
            secondlevel.level2(args);
            Console.Read();
            return;
        }
       */

        if (args[1] == "-level5")
        {
            fifthlevel.level5(args);
            Console.Read();
            return;
        }

        else if (args[1] == "-level6")
        {
            sixthlevel.level6(args);
            Console.Read();
            return;
        }

        else if (args[1] == "-level7")
        {
            seventhlevel.level7(args);
            Console.Read();
            return;
        }

        else if (!args[1].Contains("-level") || args[1] != "-level4" || args[1] != "-level5" || args[1] != "-level6" || args[1] != "-level7")
        {
            Console.WriteLine("Error, wrong level\n");
            Console.WriteLine("Level must be from -level1-7");
            Console.Read();
            return;
        }
    }
}
