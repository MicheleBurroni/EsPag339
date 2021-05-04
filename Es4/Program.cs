using System;
using System.IO;

namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\burro\source\repos\EsPag339\Es4\bin\Debug\netcoreapp3.1\File1";
            string fileout = @"C:\Users\burro\source\repos\EsPag339\Es4\bin\Debug\netcoreapp3.11File2 ";
            if (File.Exists(file))
            {
                using (StreamReader r = new StreamReader(file))
                {
                    StreamWriter w = new StreamWriter(fileout);
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        w.WriteLine(line);
                    }
                    w.Flush();
                }
            }
        }
    }
}
