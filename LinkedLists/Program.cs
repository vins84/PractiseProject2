using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new LinkedList<string>();
            
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            presidents.RemoveFirst();
            //presidents.AddFirst("John F Kennedy");                                    //This is perfectly valid
            LinkedListNode<string> kennedy = presidents.AddFirst("John F Kennedy");     //This is even better as we already specified the node thus no need to search for it in a future

            LinkedListNode<string> nixon = presidents.Find("Richard Nixon");    // This is how you specify the node
            presidents.AddAfter(nixon, "Gerald Ford");                          // This presidents.AddAfter("Richard Nixon", "Gerald Ford"); wont work as you need to specify the node 
                                                                                /* Find method in finding the node is not ver efficient as it needs to look up the whole list */

            foreach (var president in presidents)
            {
                Console.WriteLine(president);
            }

            //======================================        STACK        ==========================================
                    /* Stack is a group of entries stack on top of each other.
                     * It is not indexed thus it needs to be removed one by one starting from the top of the stack.
                     * LAST-in First-out */

            Console.WriteLine("\n\t=====================      STACK       ===========================");
            Stack<string> books = new Stack<string>();
            
                    /* Notice that books are displayed in a reverse order. 
                     * They are in the order they will be taken away from the stack */

            books.Push("Programming WPF");                          // Push adds the item on top of the stack
            books.Push("The Philosophy book");
            books.Push("Heat and Thermodynamics");
            books.Push("Harry Potter");

            Console.WriteLine(" All Books: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
                    
            string peek = books.Peek();                             // Peek just peeking on the items on a stack
            Console.WriteLine("\r\tThe item peeked is :" + peek);

            string topItem = books.Pop();                           // Pop removes the item from the top of the stack
            Console.WriteLine("\tTop item which was :" + topItem);
            Console.WriteLine(" All Books: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            //======================================        Queue        ==========================================
                /* Queue is essentially the same as stack just in an opposite way.
                 * First-in First-out from the stack */

                // it is particuarly useful for tasks such as on a server.

            Console.WriteLine("\n\t=====================      QUEUE       ===========================");
            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Buy washing powder");                // Enqueue adds the item to the end of the list
            tasks.Enqueue("Get the post");
            tasks.Enqueue("Play a game");
            tasks.Enqueue("Kiss your wife");

            Console.WriteLine(" All tasks: ");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            string peekTask = tasks.Peek();                     //  Peek just peeking on the items on a Queue 
            Console.WriteLine("\tThe task that was peeked is : " + peekTask);

            string deleteTask = tasks.Dequeue();                // Dequeue removes the item from the beginning of the list
            Console.WriteLine("\tThe item that was dequeued was : " + deleteTask);

            Console.WriteLine(" All tasks: ");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }



        }
    }
}
