using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WrititngToFilesETC
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Some text";
            File.WriteAllText("test.txt", str);

            //  This file was saved to : C:\Users\miroslaw.kaczor\Documents\VisualStudioProjects\PractiseProject\WrititngToFilesETC\bin\Debug 

            /*  The WriteAllText() method creates a file with the specified path and writes the content to it. If the file already exists, it is overwritten. 
             *  The code above creates a file test.txt and writes the contents of the str string into it. 
             --  To use the File class you need to use the System.IO namespace: using System.IO; */

            string txt = File.ReadAllText("test.txt");      // if you put this line within the try it will catch an error if the file doesnt exist
            try
            {

                Console.WriteLine(txt); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Specified file does not exist");
            }
            
                    /*  This will output the content of the test.txt file.
                        The following methods are available in the File class:
                                AppendAllText() - appends text to the end of the file.
                                Create() - creates a file in the specified location.
                                Delete() - deletes the specified file.
                                Exists() - determines whether the specified file exists.
                                Copy() - copies a file to a new location.
                                Move() - moves a specified file to a new location  */

            // =======================    This is just a syntax example - This does not work as it is in here  =================================

            if (File.Exists("names.txt"))
            {
                File.AppendAllText("names.txt", "David");
            }
                            /* Fill in the blanks to check if the file "names.txt" exists. If it does, add "David" to the end of the file. */


        }
    }
}
