using System;
using System.Collections.Generic;
using System.Text;

namespace SCP // MyList<string> tests
{
    class Test
    {
        public static void Test1()
        {
            Console.WriteLine("--------------------Test1--------------------");
            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            Console.WriteLine("consider how capacity grows as we add items to System.Collection.Generic.List object");
            Console.WriteLine("creating a System.Collection.Generic.List object and adding items to it, printing Count and Capacity");

            List<string> list = new List<string>();
            list.Add("Ali"); Console.Write("Adding 'Ali' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("John"); Console.Write("Adding 'John' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("Helen"); Console.Write("Adding 'Helen' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("Alex"); Console.Write("Adding 'Alex' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("Mo"); Console.Write("Adding 'Mo' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            Console.WriteLine("creating an empty 'names' myList of strings");
            MyList names = new MyList();
            Console.WriteLine("Count of empty 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of empty 'names' myList should be 0: {0}", names.Capacity);
            Console.WriteLine("adding 5 names to 'names' myList ...");
            names.Add("Ali");
            Console.Write("Adding 'Ali' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 1: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("John"); Console.Write("Adding 'John' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 2: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("Helen"); Console.Write("Adding 'Helen' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 3: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("Alex"); Console.Write("Adding 'Alex' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 4: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("Mo"); Console.Write("Adding 'Mo' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 5: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);
            Console.WriteLine();

            Console.WriteLine("clearing the 'names' myList .....");
            names.Clear();
            Console.Write("Content of 'names' myList, should be empty : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);
            Console.WriteLine();

            Console.WriteLine("trimming excess cells in 'names' myList ...");
            names.TrimExcess();
            Console.WriteLine("Count of 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 0: {0}", names.Capacity);
            Console.WriteLine();
            #endregion
        }

        public static void Test2()
        {
            Console.WriteLine("--------------------Test2--------------------");
            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            Console.WriteLine("consider how items are inserted into System.Collection.Generic.List object");
            Console.WriteLine("creating a System.Collection.Generic.List object and inserting items into it at given indexes, printing items, count and capacity ...");
            List<string> list = new List<string>();
            list.Insert(list.Count, "Alex"); //Count is 0 and Alex should be inserted at index 0
            Console.Write("Content of 'list', should be 'Alex' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 1: {0}", list.Count);
            Console.WriteLine();

            list.Insert(list.Count, "Mo"); //Count is 1 and Mo should be inserted at index 1
            Console.Write("Content of 'list', should be 'Alex Mo' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 2: {0}", list.Count);
            Console.WriteLine();

            list.Insert(0, "John"); //John should be inserted at index 0 and Alex and Mo should be moved along
            Console.Write("Content of 'list', should be 'John Alex Mo' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 3: {0}", list.Count);
            Console.WriteLine();

            list.Insert(0, "Ali");
            Console.Write("Content of 'list', should be 'Ali John Alex Mo' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 4: {0}", list.Count);
            Console.WriteLine();

            list.Insert(2, "Helen");
            Console.Write("Content of 'list', should be 'Ali John Helen Alex Mo' : "); Print(list);
            Console.WriteLine("Count of 'list' should be 5: {0}", list.Count);
            Console.WriteLine();
            try
            {
                list.Insert(6, "Alice"); //should be illegal because index 5 is not used
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("FAILED Attempt: Attempt to insert into an illegal position, index 5 is available"); //expect to see this message
            }
            Console.WriteLine("inserting 3 more at the end: Alice Hussain Albert at indexes 5,6,and 7 ...");
            list.Insert(5, "Alice");
            list.Insert(6, "Hussain");
            list.Insert(7, "Albert");
            Console.Write("Content of 'list', should be 'Ali John Helen Alex Mo Alice Hussain Albert' : "); Print(list);
            Console.WriteLine("Count of 'list' should be 8: {0}", list.Count);
            Console.WriteLine("Capacity of 'list' should be 8: {0}", list.Capacity);
            try
            {
                list.Insert(8, "Hassan"); //attempting to add one at the end - should be ok because capacity increases automatically
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("FAILED Attempt: Attempt to insert into an illegal position");
            }
            Console.Write("Content of 'list', should be 'Ali John Helen Alex Mo Alice Hussain Albert Hassan' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 9: {0}", list.Count);
            Console.WriteLine("Capacity of 'list' should be 16: {0}", list.Capacity);
            Console.WriteLine("######################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            Console.WriteLine("creating an empty 'names' myList of strings");
            MyList names = new MyList();

            Console.WriteLine("'names' myList should be empty");
            Console.Write("'names' myList contents : "); Print(names.ToArray());

            Console.WriteLine("Inserting 5 names into the 'names' myList ...");
            names.Insert(names.Count, "Alex");
            Console.Write("'names' myList contents should be 'Alex' : "); Print(names.ToArray());
            names.Insert(names.Count, "Mo");
            Console.Write("'names' myList contents should be 'Alex Mo' : "); Print(names.ToArray());
            names.Insert(10, "Basil"); //System.Collections.Generic.List does not support this - It throws
            Console.Write("'names' myList contents should be 'Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert(0, "John");
            Console.Write("'names' myList contents should be 'John Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert(0, "Ali");
            Console.Write("'names' myList contents should be 'Ali John Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert(2, "Helen");
            Console.Write("'names' myList contents should be 'Ali John Helen Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert("Mobly"); //System.Collections.Generic.List does not have this overload
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo Basil Mobly' : "); Print(names.ToArray());

            Console.WriteLine("Count of 'names' myList should be 7: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);
            Console.WriteLine("Attempting to insert at index 8 where index 7 is available ...");
            try
            {
                names.Insert(8, "Alice"); //should be ok - Alice should be pushed ot index 7
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("FAILED Attempt: Attempt to insert into an illegal position"); //expect to see this message
            }
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo Basil Mobly Alice' : "); Print(names.ToArray());

            Console.WriteLine("Inserting 3 more at the end: Rupert Hussain Albert ...");
            names.Insert(101, "Rupert");
            names.Insert(102, "Hussain");
            names.Insert(103, "Albert");
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo Basil Mobly Alice Rupert Hussain Albert' : "); Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 11: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 16: {0}", names.Capacity);

            Console.WriteLine("Attempting to insert Hassan at index 8  ...");
            try
            {
                names.Insert(8, "Hassan"); //attempting to add one at the end - should be ok because capacity increases automatically
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Attemp to insert into an illegal position");
            }
            Console.Write("Content of 'names' myList , should be 'Ali John Helen Alex Mo Basil Mobly Alice Hassan Rupert Hussain Albert' : "); Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 12: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 16: {0}", names.Capacity);

            Console.WriteLine("Testing method Contains ...");
            Console.Write("Content of 'names' myList : "); Print(names.ToArray());
            Console.WriteLine("'names' myList contains Mo should return TRUE : {0}", names.Contains("Mo"));
            Console.WriteLine("'names' myList contains Alice should return TRUE : {0}", names.Contains("Alice"));
            Console.WriteLine("'names' myList contains Rose should return FALSE : {0}", names.Contains("Rose"));

            Console.WriteLine("Testing method IndexOf ...");
            Console.WriteLine("'names' myList IndexOf Mo should return 4 : {0}", names.IndexOf("Mo"));
            Console.WriteLine("'names' myList IndexOf Alice should return 7 : {0}", names.IndexOf("Alice"));
            Console.WriteLine("'names' myList IndexOf Rose should return -1 : {0}", names.IndexOf("Rose"));

            Console.WriteLine("Removing 3 names from the 'names' myList");
            Console.WriteLine("Testing method RemoveAt ...");
            Console.WriteLine("Removing from Indexes 1 and 3 respectively ..");
            names.RemoveAt(1); //remove John
            names.RemoveAt(3); //remove Mo
            Console.Write("'names' myList should contain 'Ali Helen Alex Basil Mobly Alice Hassan Rupert Hussain Albert' : "); Print(names.ToArray());


            Console.WriteLine("Testing method Remove ...");
            Console.WriteLine("Removing Hussain ...");
            names.Remove("Hussain");
            Console.Write("Content of 'names' myList should be 'Ali Helen Alex Basil Mobly Alice Hassan Rupert Albert': "); Print(names.ToArray());
            Console.WriteLine();
            #endregion
        }

        public static void Test3()
        {
            Console.WriteLine("--------------------Test3--------------------");
            #region("TESTING YOUR IMPLEMENTATION")


            Console.WriteLine("creating a 'names' myList of 5 strings using array");
            string[] a1 = new string[] { "Ali", "John", "Helen", "Alex", "Mo" };
            MyList names = new MyList(a1);
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo' : "); Print(names.ToArray());

            Console.WriteLine("testing method Reverse ...");
            Console.WriteLine("Reversing 'names' myList .... ");
            names.Reverse();
            Console.Write("'names' myList should contain 'Mo Alex Helen John Ali' : "); Print(names.ToArray());

            Console.WriteLine("Testing method ToArray ...");
            Console.WriteLine("Dumping the elements of 'names' myList to an array ..");
            string[] a2 = names.ToArray();
            Console.Write("Arry a2 should print 'Mo Alex Helen John Ali' : "); Print(a2);

            Console.WriteLine("Testing method Clear ...");
            Console.WriteLine("Clearing the 'names' myList ...");
            names.Clear();
            Console.Write("'names' myList should contain nothing : "); Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);

            Console.WriteLine("Testing method AddRange ...");
            Console.WriteLine("Adding the range of elements of the array to the end of the 'names' myList ...");
            names.AddRange(a2);
            Console.Write("'names' myList should contain 'Mo Alex Helen John Ali' : "); Print(names.ToArray());
            Console.WriteLine();
            #endregion
        }

        public static void Test4()
        {
            Console.WriteLine("--------------------Test4--------------------");
            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("creating empty 'names' myList of strings with initial capacity 5");
            MyList names = new MyList(5);

            Console.WriteLine("'names' myList Capacity should be 5 : {0}", names.Capacity);

            Console.WriteLine("inserting 5 names into the 'names' myList ..");
            names.Insert(names.Count, "Alex");
            names.Insert(names.Count, "Mo");
            names.Insert(0, "John");
            names.Insert(0, "Ali");
            names.Insert(2, "Helen");
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo' : "); Print(names.ToArray());

            Console.WriteLine("Testing method Sort ...");
            Console.WriteLine("Sorting the 'names' myList ..."); names.Sort();
            Console.Write("'names' myList should contain 'Alex Ali Helen John Mo' : "); Print(names.ToArray());

            Console.WriteLine("Performing binary search on 'Ali' should return 1 : {0}", names.BinarySearch("Ali"));
            Console.WriteLine("performing binary search on 'Helen' should return 2 : {0}", names.BinarySearch("Helen"));
            Console.WriteLine("performing binary search on 'Archibald' should return -1 : {0}", names.BinarySearch("Albert"));
            Console.WriteLine();
            #endregion
        }

        public static void Test5()
        {
            Console.WriteLine("--------------------Test5--------------------");
            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            //with System.Collections.Generic.List object assignment does not automnatically 
            //  add to collection
            try
            {
                List<string> test1 = new List<string>(); //declaring and creating 'list1' of type List and capacity of 5
                test1[0] = "Ali"; test1[1] = "John"; test1[2] = "Helen"; test1[3] = "Alex"; test1[4] = "Mo";
                Console.Write("'test' is a MyList of string : "); Print(test1.ToArray());
            }
            catch
            {
                Console.WriteLine("Illegal assignment !"); //we should get this message !
            }
            Console.WriteLine();

            //All .NET Objects inherit from Object class and so ..
            //  All .NET Objects inherit 'Object.Equals(Object obj)' method.
            //Object.Equals(Object obj) checks if the specified object equals
            //  the current object. It returns false for different instances of the same type ..
            //  object o1 = new object(); object o2 = new object();
            //  o2.Equals(o1); //retuns false
            //  o2.Equals(o2); //returns true
            char[] array = new char[4] { 'A', 'B', 'C', 'D' };
            List<char> list1 = new List<char>(array);
            List<char> list2 = new List<char>(array);
            Console.WriteLine("Comparing list1 and list2, both of type System.Collections.Generic.List ...");
            Console.Write("'list1' is a list of character : "); Print(list1);
            Console.Write("'list2' is a list of character : "); Print(list2);

            Console.WriteLine("Testing method Equals ...");
            Console.WriteLine("'list1.Equals(list1)' should return TRUE : {0}", list1.Equals(list1));
            Console.WriteLine("'list1[0].Equals(list2[0]))' should return TRUE : {0}", list1[0].Equals(list2[0])); //char is value type
            Console.WriteLine("'list1.Equals(list2)' should return FLASE : {0}", list1.Equals(list2)); //List object is reference type
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            Console.WriteLine("Developing MyList behavior that changes from System.Collections.Generic.List class");

            //MyList.Equals(Object obj) overrides the inherited to return TRUE (not False) for different instances of the same type. So ..
            //  object o1 = new MyList<T>(); object o2 = new MyList<T>();
            //  o2.Equals(o1); //retuns true
            //  o2.Equals(o2); //returns true
            MyList names1 = new MyList(5); //declaring and creating 'names1' of type MyList and capacity of 5
            names1[0] = "Ali"; names1[1] = "John"; names1[2] = "Helen"; names1[3] = "Alex"; names1[4] = "Mo";
            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());

            MyList names2 = null; //declaring 'names2' of type MyList and assigning it to NULL
            Console.WriteLine("'names1.Equals(names2)' should return FALSE : {0}", names1.Equals(names2));

            names2 = new MyList(); //creating 'names2' of type MyList
            names2[0] = "Ali"; names2[1] = "John"; names2[2] = "Helen"; names2[3] = "Alex"; names2[4] = "Mo"; //assignment must add to collection
            names1.TrimExcess(); names2.TrimExcess(); //we have to TrimExcess because capacities have to also be the same

            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());
            Console.Write("'names2' is a MyList of string : "); Print(names2.ToArray());
            Console.WriteLine("'names1.Equals(names1)' should return TRUE : {0}", names1.Equals(names1));
            Console.WriteLine("'names1[0].Equals(names2[0]))' should return TRUE : {0}", names1[0].Equals(names2[0])); //albeit, string is reference type
            Console.WriteLine("'names1.Equals(names2)' should return TRUE : {0}", names1.Equals(names2)); //albeit, MyList objects are reference type
            Console.WriteLine();
            #endregion

            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            //.NET Operators are expressions that work like methods. For example mathematical oertors are often
            //  used to work like methods. For example you can use mathematical operators on string objects
            Console.Write("'list1' is a list of character : "); Print(list1);
            Console.Write("'list2' is a list of character : "); Print(list2);
            Console.WriteLine("'list1 == list2' should return FALSE : {0}", list1 == list2);
            Console.WriteLine("'list1 != list2' should return TRUE : {0}", list1 != list2);
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            //object.operator == (object left, object right) checks to see if left equals
            //  right. So, it returns false for different instances of the same type ..
            //  object o1 = new object(); object o2 = new object();
            //  o2 == o1 //retuns false
            //MyList.operator == (object left, object right) implements
            //  to return true for different instances of the same type. So ..
            //  object o1 = new MyList<T>(); object o2 = new MyList<T>();
            //  o2 == o1 //retuns true
            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());
            Console.Write("'names2' is a MyList of string : "); Print(names2.ToArray());
            Console.WriteLine("'names1 == names2' should return TRUE : {0}", names1 == names2); // Different behavior
            Console.WriteLine("changing the content of 'names2', they are now ...");
            names2[0] = "Alice"; names2[1] = "Hussain"; names2[2] = "Albert"; names2[3] = "Hassan"; names2[4] = "Joe";
            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());
            Console.Write("'names2' is a MyList of string : "); Print(names2.ToArray());
            Console.WriteLine("'names1 != names2' should return TRUE : {0}", names1 != names2);
            Console.Write("'names1 + names2' should add content of 'names2' to 'names1' we should have : "); Print((names1 + names2).ToArray());
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion
        }
        static void Print<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

namespace GCP // MyList<T> tests
{
    class Test
    {
        public static void Test1()
        {
            Console.WriteLine("--------------------Test1--------------------");
            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            Console.WriteLine("consider how capacity grows as we add items to System.Collection.Generic.List object");
            Console.WriteLine("creating a System.Collection.Generic.List object and adding items to it, printing Count and Capacity");

            List<string> list = new List<string>();
            list.Add("Ali"); Console.Write("Adding 'Ali' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("John"); Console.Write("Adding 'John' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("Helen"); Console.Write("Adding 'Helen' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("Alex"); Console.Write("Adding 'Alex' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            list.Add("Mo"); Console.Write("Adding 'Mo' to list, list content is : ");
            Print(list);
            Console.WriteLine("'list' Count: {0}", list.Count);
            Console.WriteLine("'list' Capacity: {0}", list.Capacity);
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            Console.WriteLine("creating an empty 'names' myList of strings");
            MyList<string> names = new MyList<string>();
            Console.WriteLine("Count of empty 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of empty 'names' myList should be 0: {0}", names.Capacity);
            Console.WriteLine("adding 5 names to 'names' myList ...");
            names.Add("Ali");
            Console.Write("Adding 'Ali' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 1: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("John"); Console.Write("Adding 'John' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 2: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("Helen"); Console.Write("Adding 'Helen' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 3: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("Alex"); Console.Write("Adding 'Alex' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 4: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 4: {0}", names.Capacity);
            names.Add("Mo"); Console.Write("Adding 'Mo' to 'names' myList, content is : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 5: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);
            Console.WriteLine();

            Console.WriteLine("clearing the 'names' myList .....");
            names.Clear();
            Console.Write("Content of 'names' myList, should be empty : ");
            Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);
            Console.WriteLine();

            Console.WriteLine("trimming excess cells in 'names' myList ...");
            names.TrimExcess();
            Console.WriteLine("Count of 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 0: {0}", names.Capacity);
            Console.WriteLine();
            #endregion
        }

        public static void Test2()
        {
            Console.WriteLine("--------------------Test2--------------------");
            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            Console.WriteLine("consider how items are inserted into System.Collection.Generic.List object");
            Console.WriteLine("creating a System.Collection.Generic.List object and inserting items into it at given indexes, printing items, count and capacity ...");
            List<string> list = new List<string>();
            list.Insert(list.Count, "Alex"); //Count is 0 and Alex should be inserted at index 0
            Console.Write("Content of 'list', should be 'Alex' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 1: {0}", list.Count);
            Console.WriteLine();

            list.Insert(list.Count, "Mo"); //Count is 1 and Mo should be inserted at index 1
            Console.Write("Content of 'list', should be 'Alex Mo' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 2: {0}", list.Count);
            Console.WriteLine();

            list.Insert(0, "John"); //John should be inserted at index 0 and Alex and Mo should be moved along
            Console.Write("Content of 'list', should be 'John Alex Mo' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 3: {0}", list.Count);
            Console.WriteLine();

            list.Insert(0, "Ali");
            Console.Write("Content of 'list', should be 'Ali John Alex Mo' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 4: {0}", list.Count);
            Console.WriteLine();

            list.Insert(2, "Helen");
            Console.Write("Content of 'list', should be 'Ali John Helen Alex Mo' : "); Print(list);
            Console.WriteLine("Count of 'list' should be 5: {0}", list.Count);
            Console.WriteLine();
            try
            {
                list.Insert(6, "Alice"); //should be illegal because index 5 is not used
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("FAILED Attempt: Attempt to insert into an illegal position, index 5 is available"); //expect to see this message
            }
            Console.WriteLine("inserting 3 more at the end: Alice Hussain Albert at indexes 5,6,and 7 ...");
            list.Insert(5, "Alice");
            list.Insert(6, "Hussain");
            list.Insert(7, "Albert");
            Console.Write("Content of 'list', should be 'Ali John Helen Alex Mo Alice Hussain Albert' : "); Print(list);
            Console.WriteLine("Count of 'list' should be 8: {0}", list.Count);
            Console.WriteLine("Capacity of 'list' should be 8: {0}", list.Capacity);
            try
            {
                list.Insert(8, "Hassan"); //attempting to add one at the end - should be ok because capacity increases automatically
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("FAILED Attempt: Attempt to insert into an illegal position");
            }
            Console.Write("Content of 'list', should be 'Ali John Helen Alex Mo Alice Hussain Albert Hassan' : ");
            Print(list);
            Console.WriteLine("Count of 'list' should be 9: {0}", list.Count);
            Console.WriteLine("Capacity of 'list' should be 16: {0}", list.Capacity);
            Console.WriteLine("######################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            Console.WriteLine("creating an empty 'names' myList of strings");
            MyList<string> names = new MyList<string>();

            Console.WriteLine("'names' myList should be empty");
            Console.Write("'names' myList contents : "); Print(names.ToArray());

            Console.WriteLine("Inserting 5 names into the 'names' myList ...");
            names.Insert(names.Count, "Alex");
            Console.Write("'names' myList contents should be 'Alex' : "); Print(names.ToArray());
            names.Insert(names.Count, "Mo");
            Console.Write("'names' myList contents should be 'Alex Mo' : "); Print(names.ToArray());
            names.Insert(10, "Basil"); //System.Collections.Generic.List does not support this - It throws
            Console.Write("'names' myList contents should be 'Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert(0, "John");
            Console.Write("'names' myList contents should be 'John Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert(0, "Ali");
            Console.Write("'names' myList contents should be 'Ali John Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert(2, "Helen");
            Console.Write("'names' myList contents should be 'Ali John Helen Alex Mo Basil' : "); Print(names.ToArray());
            names.Insert("Mobly"); //System.Collections.Generic.List does not have this overload
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo Basil Mobly' : "); Print(names.ToArray());

            Console.WriteLine("Count of 'names' myList should be 7: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);
            Console.WriteLine("Attempting to insert at index 8 where index 7 is available ...");
            try
            {
                names.Insert(8, "Alice"); //should be ok - Alice should be pushed ot index 7
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("FAILED Attempt: Attempt to insert into an illegal position"); //expect to see this message
            }
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo Basil Mobly Alice' : "); Print(names.ToArray());

            Console.WriteLine("Inserting 3 more at the end: Rupert Hussain Albert ...");
            names.Insert(101, "Rupert");
            names.Insert(102, "Hussain");
            names.Insert(103, "Albert");
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo Basil Mobly Alice Rupert Hussain Albert' : "); Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 11: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 16: {0}", names.Capacity);

            Console.WriteLine("Attempting to insert Hassan at index 8  ...");
            try
            {
                names.Insert(8, "Hassan"); //attempting to add one at the end - should be ok because capacity increases automatically
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Attemp to insert into an illegal position");
            }
            Console.Write("Content of 'names' myList , should be 'Ali John Helen Alex Mo Basil Mobly Alice Hassan Rupert Hussain Albert' : "); Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 12: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 16: {0}", names.Capacity);

            Console.WriteLine("Testing method Contains ...");
            Console.Write("Content of 'names' myList : "); Print(names.ToArray());
            Console.WriteLine("'names' myList contains Mo should return TRUE : {0}", names.Contains("Mo"));
            Console.WriteLine("'names' myList contains Alice should return TRUE : {0}", names.Contains("Alice"));
            Console.WriteLine("'names' myList contains Rose should return FALSE : {0}", names.Contains("Rose"));

            Console.WriteLine("Testing method IndexOf ...");
            Console.WriteLine("'names' myList IndexOf Mo should return 4 : {0}", names.IndexOf("Mo"));
            Console.WriteLine("'names' myList IndexOf Alice should return 7 : {0}", names.IndexOf("Alice"));
            Console.WriteLine("'names' myList IndexOf Rose should return -1 : {0}", names.IndexOf("Rose"));

            Console.WriteLine("Removing 3 names from the 'names' myList");
            Console.WriteLine("Testing method RemoveAt ...");
            Console.WriteLine("Removing from Indexes 1 and 3 respectively ..");
            names.RemoveAt(1); //remove John
            names.RemoveAt(3); //remove Mo
            Console.Write("'names' myList should contain 'Ali Helen Alex Basil Mobly Alice Hassan Rupert Hussain Albert' : "); Print(names.ToArray());


            Console.WriteLine("Testing method Remove ...");
            Console.WriteLine("Removing Hussain ...");
            names.Remove("Hussain");
            Console.Write("Content of 'names' myList should be 'Ali Helen Alex Basil Mobly Alice Hassan Rupert Albert': "); Print(names.ToArray());
            Console.WriteLine();
            #endregion
        }

        public static void Test3()
        {
            Console.WriteLine("--------------------Test3--------------------");
            #region("TESTING YOUR IMPLEMENTATION")


            Console.WriteLine("creating a 'names' myList of 5 strings using array");
            string[] a1 = new string[] { "Ali", "John", "Helen", "Alex", "Mo" };
            MyList<string> names = new MyList<string>(a1);
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo' : "); Print(names.ToArray());

            Console.WriteLine("testing method Reverse ...");
            Console.WriteLine("Reversing 'names' myList .... ");
            names.Reverse();
            Console.Write("'names' myList should contain 'Mo Alex Helen John Ali' : "); Print(names.ToArray());

            Console.WriteLine("Testing method ToArray ...");
            Console.WriteLine("Dumping the elements of 'names' myList to an array ..");
            string[] a2 = names.ToArray();
            Console.Write("Arry a2 should print 'Mo Alex Helen John Ali' : "); Print(a2);

            Console.WriteLine("Testing method Clear ...");
            Console.WriteLine("Clearing the 'names' myList ...");
            names.Clear();
            Console.Write("'names' myList should contain nothing : "); Print(names.ToArray());
            Console.WriteLine("Count of 'names' myList should be 0: {0}", names.Count);
            Console.WriteLine("Capacity of 'names' myList should be 8: {0}", names.Capacity);

            Console.WriteLine("Testing method AddRange ...");
            Console.WriteLine("Adding the range of elements of the array to the end of the 'names' myList ...");
            names.AddRange(a2);
            Console.Write("'names' myList should contain 'Mo Alex Helen John Ali' : "); Print(names.ToArray());
            Console.WriteLine();
            #endregion
        }

        public static void Test4()
        {
            Console.WriteLine("--------------------Test4--------------------");
            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("creating empty 'names' myList of strings with initial capacity 5");
            MyList<string> names = new MyList<string>(5);

            Console.WriteLine("'names' myList Capacity should be 5 : {0}", names.Capacity);

            Console.WriteLine("inserting 5 names into the 'names' myList ..");
            names.Insert(names.Count, "Alex");
            names.Insert(names.Count, "Mo");
            names.Insert(0, "John");
            names.Insert(0, "Ali");
            names.Insert(2, "Helen");
            Console.Write("'names' myList should contain 'Ali John Helen Alex Mo' : "); Print(names.ToArray());

            Console.WriteLine("Testing method Sort ...");
            Console.WriteLine("Sorting the 'names' myList ..."); names.Sort();
            Console.Write("'names' myList should contain 'Alex Ali Helen John Mo' : "); Print(names.ToArray());

            Console.WriteLine("Performing binary search on 'Ali' should return 1 : {0}", names.BinarySearch("Ali"));
            Console.WriteLine("performing binary search on 'Helen' should return 2 : {0}", names.BinarySearch("Helen"));
            Console.WriteLine("performing binary search on 'Archibald' should return -1 : {0}", names.BinarySearch("Albert"));
            Console.WriteLine();
            #endregion
        }

        public static void Test5()
        {
            Console.WriteLine("--------------------Test5--------------------");
            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            //with System.Collections.Generic.List object assignment does not automnatically 
            //  add to collection
            try
            {
                List<string> test1 = new List<string>(); //declaring and creating 'list1' of type List and capacity of 5
                test1[0] = "Ali"; test1[1] = "John"; test1[2] = "Helen"; test1[3] = "Alex"; test1[4] = "Mo";
                Console.Write("'test' is a MyList of string : "); Print(test1.ToArray());
            }
            catch
            {
                Console.WriteLine("Illegal assignment !"); //we should get this message !
            }
            Console.WriteLine();

            //All .NET Objects inherit from Object class and so ..
            //  All .NET Objects inherit 'Object.Equals(Object obj)' method.
            //Object.Equals(Object obj) checks if the specified object equals
            //  the current object. It returns false for different instances of the same type ..
            //  object o1 = new object(); object o2 = new object();
            //  o2.Equals(o1); //retuns false
            //  o2.Equals(o2); //returns true
            char[] array = new char[4] { 'A', 'B', 'C', 'D' };
            List<char> list1 = new List<char>(array);
            List<char> list2 = new List<char>(array);
            Console.WriteLine("Comparing list1 and list2, both of type System.Collections.Generic.List ...");
            Console.Write("'list1' is a list of character : "); Print(list1);
            Console.Write("'list2' is a list of character : "); Print(list2);

            Console.WriteLine("Testing method Equals ...");
            Console.WriteLine("'list1.Equals(list1)' should return TRUE : {0}", list1.Equals(list1));
            Console.WriteLine("'list1[0].Equals(list2[0]))' should return TRUE : {0}", list1[0].Equals(list2[0])); //char is value type
            Console.WriteLine("'list1.Equals(list2)' should return FLASE : {0}", list1.Equals(list2)); //List object is reference type
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            Console.WriteLine("Developing MyList behavior that changes from System.Collections.Generic.List class");

            //MyList.Equals(Object obj) overrides the inherited to return TRUE (not False) for different instances of the same type. So ..
            //  object o1 = new MyList<T>(); object o2 = new MyList<T>();
            //  o2.Equals(o1); //retuns true
            //  o2.Equals(o2); //returns true
            MyList<string> names1 = new MyList<string>(5); //declaring and creating 'names1' of type MyList and capacity of 5
            names1[0] = "Ali"; names1[1] = "John"; names1[2] = "Helen"; names1[3] = "Alex"; names1[4] = "Mo";
            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());

            MyList<string> names2 = null; //declaring 'names2' of type MyList and assigning it to NULL
            Console.WriteLine("'names1.Equals(names2)' should return FALSE : {0}", names1.Equals(names2));

            names2 = new MyList<string>(); //creating 'names2' of type MyList
            names2[0] = "Ali"; names2[1] = "John"; names2[2] = "Helen"; names2[3] = "Alex"; names2[4] = "Mo"; //assignment must add to collection
            names1.TrimExcess(); names2.TrimExcess(); //we have to TrimExcess because capacities have to also be the same

            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());
            Console.Write("'names2' is a MyList of string : "); Print(names2.ToArray());
            Console.WriteLine("'names1.Equals(names1)' should return TRUE : {0}", names1.Equals(names1));
            Console.WriteLine("'names1[0].Equals(names2[0]))' should return TRUE : {0}", names1[0].Equals(names2[0])); //albeit, string is reference type
            Console.WriteLine("'names1.Equals(names2)' should return TRUE : {0}", names1.Equals(names2)); //albeit, MyList objects are reference type
            Console.WriteLine();
            #endregion

            #region("LEARNING")
            Console.WriteLine("################# LEARNING #####################");
            //.NET Operators are expressions that work like methods. For example mathematical oertors are often
            //  used to work like methods. For example you can use mathematical operators on string objects
            Console.Write("'list1' is a list of character : "); Print(list1);
            Console.Write("'list2' is a list of character : "); Print(list2);
            Console.WriteLine("'list1 == list2' should return FALSE : {0}", list1 == list2);
            Console.WriteLine("'list1 != list2' should return TRUE : {0}", list1 != list2);
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion

            #region("TESTING YOUR IMPLEMENTATION")
            Console.WriteLine("############## Testing your implementation ###########");
            //object.operator == (object left, object right) checks to see if left equals
            //  right. So, it returns false for different instances of the same type ..
            //  object o1 = new object(); object o2 = new object();
            //  o2 == o1 //retuns false
            //MyList.operator == (object left, object right) implements
            //  to return true for different instances of the same type. So ..
            //  object o1 = new MyList<T>(); object o2 = new MyList<T>();
            //  o2 == o1 //retuns true
            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());
            Console.Write("'names2' is a MyList of string : "); Print(names2.ToArray());
            Console.WriteLine("'names1 == names2' should return TRUE : {0}", names1 == names2); // Different behavior
            Console.WriteLine("changing the content of 'names2', they are now ...");
            names2[0] = "Alice"; names2[1] = "Hussain"; names2[2] = "Albert"; names2[3] = "Hassan"; names2[4] = "Joe";
            Console.Write("'names1' is a MyList of string : "); Print(names1.ToArray());
            Console.Write("'names2' is a MyList of string : "); Print(names2.ToArray());
            Console.WriteLine("'names1 != names2' should return TRUE : {0}", names1 != names2);
            Console.Write("'names1 + names2' should add content of 'names2' to 'names1' we should have : "); Print((names1 + names2).ToArray());
            Console.WriteLine("#####################################################");
            Console.WriteLine();
            #endregion
        }
        static void Print<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
