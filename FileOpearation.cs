using System;
using System.IO;
using System.Text;

namespace FileCreation
{
    internal class FileOpearation
    {
        static void Main(string[] args)
        {
            string pathName = @"C:\Program\myfile.txt";

            //to create file
            FileStream fs =File.Create("C:\\Program\\myfile1.txt");

            // create a file at pathName and write "Hello World" to the file
            File.WriteAllText(pathName, "Hello World");

            //to read file
            string readText = File.ReadAllText(pathName);

            /*
            using (FileStream fs1 = File.Open(pathName, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }*/


                /*File.OpenRead(pathName);
                File.OpenText(pathName);
                File.OpenWrite(pathName);
                */



                Console.WriteLine(readText);

        }
    }
}
