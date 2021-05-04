using System;
using System.IO;

namespace Es7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line;
            Console.WriteLine("Inserisci il nome del file");
            string file = Convert.ToString(Console.ReadLine());
            StreamReader r = new StreamReader(file);
            StreamWriter w = new StreamWriter(file);
            while ((line = r.ReadLine()) != null)               
            {
                r.Close();
                
                for (int i = line.Length-1; i >=0 ; i--)
                {
                    w.Write(line[i]);
                }
                w.WriteLine();
                
            }
            w.Flush();
            w.Close();

        }
    }
}
