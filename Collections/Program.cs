using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> colors = new List<string>();           // in () the size of the "array" can be specified
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Pink");
            colors.Add("Blue");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            /* Outputs Red, Green, Pink, Blue */

                /*  We defined a List that stores strings and iterated through it using a foreach loop. 
                    The List class contains a number of useful methods:
                    Add adds an element to the List.
                    Clear removes all elements from the List.
                    Contains determines whether the specified element is contained in the List.
                    Count returns the number of elements in the List.
                    Insert adds an element at the specified index.
                    Reverse reverses the order of the elements in the List. */

                // So why use Lists instead of arrays? Because, unlike arrays, the group of objects you work with in a collection can grow and shrink dynamically.

                /*  Commonly used generic collection types include:
                    Dictionary<TKey, TValue> represents a collection of key/value pairs that are organized based on the key.
                    List<T> represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.
                    Queue<T> represents a first in, first out (FIFO) collection of objects.
                    Stack<T> represents a last in, first out (LIFO) collection of objects. */

            //======================           Non Blank String List            =================================
            Console.WriteLine("===========     Non Blank String List      =====================");
            NonBlankStringList list = new NonBlankStringList();
            list.Add("Item added at index 0");
            list[0] = ("Item inserted at index 0");
            list.Add("Item added at index 1");
            list.Insert(2, "Item inserted at index 2");

            try                                                 // Excellent error handling
            {
                list.Add("    ");                               // This will throw the exception
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);                
            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //======================         Observable Collections        ============================
            Console.WriteLine("===========     Observable Collections      =====================");
            ObservableCollection<string> listOfPresidents = new ObservableCollection<string>
            {
                 "Jimmy Carter", "Ronald Reagan", "George HW Bush" 
            };

            listOfPresidents.CollectionChanged += OnCollectionChanged;

            listOfPresidents.Add("Bill Clinton");
            listOfPresidents.Remove("Ronald Reagan");

            foreach (string item in listOfPresidents)
            {
                Console.WriteLine(item);
            }
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

        }
    }
}
