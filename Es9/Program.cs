using System;
using System.IO;
namespace Es9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fileRandom = @"C:\Users\burro\source\repos\EsPag339\Es9\bin\Debug\netcoreapp3.1\TextFile1.txt";
            string crescente = @"C:\Users\burro\source\repos\EsPag339\Es9\bin\Debug\netcoreapp3.1\TextCrescente.txt";
            string decrescente = @"C:\Users\burro\source\repos\EsPag339\Es9\bin\Debug\netcoreapp3.1\TextDecrescente.txt";
            int[] array = new int[10];
            StreamWriter w = new StreamWriter(fileRandom);          
            Random rnd = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 200);
                w.WriteLine(array[i]);
               
            }
            w.Flush();
            w.Close();            
            
            StreamWriter w1 = new StreamWriter(crescente);
            
                for (int i = 0; i < array.Length; i++)
                {
                    Array.Sort(array);
                    w1.WriteLine(array[i]);

                }         
            w1.Flush();
            w1.Close();

            StreamWriter w2 = new StreamWriter(decrescente);

            for (int i = 0; i < array.Length; i++)
            {
                Array.Sort(array);
                Array.Reverse(array);
                w2.WriteLine(array[i]);

            }
            w2.Flush();
            w2.Close();

        }
    }
}
