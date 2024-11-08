using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingmaker
{
    internal class FileReader
    {
        public static List<string[]> ReadFiles(string address)
        {
            String? line;
            List<string> lines = new List<string>();
            List<string[]> paragraphs = new List<string[]>();
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamReader sr = new StreamReader(address);
                //Read the first line of text
                line = sr.ReadLine();
                //establish a list
                //List<string> lines = new List<string>();
                //List<List<string>> paragraphs = new List<List<string>>();
                //Establish an initiator
                //int initiator = 0;
                //Continue to read until you reach end of file
                while (line != null)
                {

                    //Console.WriteLine(line);
                    lines.Add(line);

                    if (line.Contains('_'))
                    {
                        string[] arrayForMemory = new string[lines.Count()];
                        lines.CopyTo(arrayForMemory);
                        paragraphs.Add(arrayForMemory);
                        lines.Clear();
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                
                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return paragraphs;
        }
    }
}
        