using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Numeri.txt";
            if (File.Exists(file)) ;
            {
                List<string> lista = new List<string>();
                using (StreamReader r = new StreamReader(file))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lista.Add(line);
                    }
                }
            }
        }

    }
}
