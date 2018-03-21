using System;
using System.IO;
using System.Text;

namespace Class03Demo
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // string myPath = "..\\..\\..\\cats.txt";
           //// CreateAFile(myPath);
           // ReadFile(myPath);

           // Console.WriteLine("---- ADDING IN A NAME---");

           // UpdateFile(myPath);

           // Console.WriteLine("---- READ IT OUT --");

           // ReadFile(myPath);

           // DeleteFile(myPath);

          //  PracticeUsingSplit();

            ////Show Random Class

            //Random rand = new Random();
            //int first = rand.Next(0, 11);
            //Console.WriteLine(first);
            //Console.WriteLine(rand.Next(0, 11));
            //Console.WriteLine(rand.Next(0, 11));
            //Console.WriteLine(rand.Next(0, 11));


            // show Contains

            string word = "coffee";

            if(word.Contains("O"))
            {
                Console.WriteLine($"there is an O in {word}");
            }
            else
            {
                Console.WriteLine("Nope");
            }
        }

     public static void CreateAFile(string path)
        {
           
            byte[] words = new UTF8Encoding(true).GetBytes("Hello Class");


            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write("This is a test");
                }
            }
            catch (Exception)
            {

                throw;
            }

            using (FileStream fs = File.Create(path))
            {
                fs.Write(words, 0, words.Length);
            }

        }


        public static void ReadFile(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateFile(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(".NET is cool!");
            }
        }

        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public static void PracticeUsingSplit()
        {
            char[] delims = {' ', ',' , '.', ':', '\t' };
            string text = "one two three four five six seven";

            string[] words = text.Split(' ');

            foreach (string s in words)
            {
                Console.WriteLine(s);

            }
        }


    }
}
