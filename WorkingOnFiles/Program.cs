using System;
using System.IO;

namespace WorkingOnFiles
{
    class Program
    {
        static void Main(string[] args)
        {


            //folder create 

            System.IO.Directory.CreateDirectory(@"d:\tset\d2");
            Console.WriteLine((System.IO.Directory.Exists(@"d:\tset\d2")) ? "Folder exist" : "folder not exist");

            try
            {
             if (File.Exists(@"d:\tset\d2\re123.txt")) 
             System.IO.File.Move(@"d:\tset\d2\re123.txt", @"d:\tset\d2\123.txt");
            }
            catch (Exception  )
            {

                throw;
            }
            //file rename




            Console.WriteLine("Hello World!");
        }
    }
}
