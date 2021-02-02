using System;
using System.IO;
using System.Linq;
using System.Xml;

namespace WorkingOnFiles
{
    class Program
    {
        static void Main(string[] args)
        {


            //////read multiple xml

            var path = @"d:\dirXml\";
            var resultfiles = System.IO.Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);


            foreach (var file in resultfiles)
            {
                ProcessFile(file);
            }

            /////////
            Console.WriteLine("Hello World!");
        }

        static void ProcessFile(string Filename)
        {

            int totalC = 0;

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(Filename);

            XmlNodeList Clist = xmlDoc.GetElementsByTagName("ID");
            totalC = Clist.Count;
            Console.WriteLine(Filename);
            for (int i = 0; i < Clist.Count; i++)
            {
                Console.WriteLine(Clist[i].InnerText.ToString());
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine(Environment.NewLine);


        }

        static void ProcessingFile()
        {
            #region file

            //folder create 

            System.IO.Directory.CreateDirectory(@"d:\tset\d2");
            Console.WriteLine((System.IO.Directory.Exists(@"d:\tset\d2")) ? "Folder exist" : "folder not exist");

            try
            {
                if (File.Exists(@"d:\tset\d2\re123.txt"))
                    System.IO.File.Move(@"d:\tset\d2\re123.txt", @"d:\tset\d2\123.txt");
            }
            catch (Exception)
            {

                throw;
            }
            ////file rename

            #endregion


        }
    }
}
