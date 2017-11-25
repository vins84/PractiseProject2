using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lists are/behavious jsut like an array !. 
             * if you comment System.Linq you'd see on telesense that a lot of array methods are available for Lists */

            var presidents = new List<string>               // is it possible to specify List capacity by adding (12) at the end
            {
                "Jimmy Carter", "Ronald Reagan", "George HW Bush", "Bill Clinton", "George W Bush"
            };
            Console.WriteLine("Before...");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);
            Console.WriteLine("\nAdding Barack Obama");
            presidents.Add("Barack Obama");

            Console.WriteLine("Removing entries...");
            presidents.RemoveAt(3);                                      // RemoveAt is better when deleting end of list entries from a long list
            presidents.Remove("George W Bush");                         //Remove is slower but much better for removing front entries in a long list 

            Console.WriteLine("After...");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);
            Console.WriteLine("");

            string who = presidents[1];                                 // Specifies president at index 2
            Console.WriteLine("The 2nd president in the list is : " + who);

            var copyOfTheList = new ReadOnlyCollection<string>(presidents);      //By using readOnly protects the list from accidental modification

            try                                                         // Excellent Error Handling
            {
                BadCode(copyOfTheList);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            

            foreach (string president in copyOfTheList)
            {
                Console.WriteLine(president);
            }

           
        }
        static void BadCode(IList<string> lst)
        {
            lst.RemoveAt(2);
        }
    }
}
