using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    public class firstlevel
    {
        public static void level1(string[] args)
        {
       
            string filename = args[1];
            int startline = int.Parse(args[2]);
            if (startline % 2 == 0)
            {
                Console.WriteLine("Error");
                return;
            }
            int sequences = int.Parse(args[3]) * 2;
            FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            for (int i = 0; i < startline - 1; i++)
            {
                reader.ReadLine();
                Console.WriteLine(reader.ReadLine());

            }

            for (int i = 0; i < sequences; i++)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();
            file.Close();
        }
    
}

