//using System;
//using System.Collections;
//using System.Linq;

//namespace ArrayLinq
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] err = { 2, 4, 7, 1 };


//                ArrayList arrList = new ArrayList();

//            arrList.Add(
//                new Student
//                {
//                    Id = 1,
//                    FirstName = "Svetlana",
//                    LastName = "Omelchenko",
//                    Scores = new int[] { 98, 92, 81, 60 }
//                });
//            arrList.Add(
//                new Student
//                {
//                    Id = 1,
//                    FirstName = "Claire",
//                    LastName = "O’Donnell",
//                    Scores = new int[] { 75, 84, 91, 39 }
//                });
//            arrList.Add(
//                new Student
//                {
//                    Id = 2,
//                    FirstName = "Sven",
//                    LastName = "Mortensen",
//                    Scores = new int[] { 88, 94, 65, 91 }
//                });
//            arrList.Add(
//                new Student
//                {
//                    Id = 3,
//                    FirstName = "Cesar",
//                    LastName = "Garcia",
//                    Scores = new int[] { 97, 89, 85, 82 }
//                });

//            var query = from Student student in arrList
//                        where student.Scores[0] > 95
//                        select student;

//            foreach (Student s in query)
//                Console.WriteLine(s.LastName + ": " + s.Scores[0]);



//            var names = arrList.Where();

//            // Keep the console window open in debug mode.  
//            Console.WriteLine("Press any key to exit.");
//            Console.ReadKey();
//        }

//        public class Student
//        {
//            public int Id { get; set; }
//            public string FirstName { get; set; }
//            public string LastName { get; set; }
//            public int[] Scores { get; set; }
//        }


//    }
//}
