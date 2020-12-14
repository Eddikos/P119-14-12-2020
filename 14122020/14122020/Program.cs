using System;
using System.Collections;
using System.Collections.Generic;

namespace _14122020
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            var count = al.Count;
            al.Add("tyu");
            al.Add(true);
            al.Add(4567);
            al.Add(123.123);

            ArrayList al2 = new ArrayList();
            al2.Add("asd5");
            al2.Add("asd6");
            al2.Add("asd7");


            al.AddRange(al2);
            al.IndexOf(true);

            //al.RemoveAt(5);
            al.RemoveRange(5, 1);
            al.Reverse();
            //al.Sort();

            //al.Remove(true);
            //al.Remove("tyu");

            foreach (var item in al)
            { 
                Console.WriteLine(item); 
            }

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            var elovset = st.Pop();
            st.Pop();
            st.Pop();

            Queue qu = new Queue();
            qu.Enqueue("a");
            qu.Enqueue("b");
            qu.Enqueue("c");
            qu.Enqueue("d");
            qu.Enqueue("e");

            var elovset2 = qu.Dequeue();
            qu.Dequeue();

            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            Console.WriteLine(elovset2);


            SortedList sl = new SortedList();
            sl.Add(878, 45678);
            sl.Add("l", "lenkeran");
            sl.Add("g", true);
            sl.Add("s", "Sumqayit");

            foreach (var key in sl.Keys)
            {
                Console.WriteLine(sl[key]);
            }

            sl.ContainsKey("l");
            sl.ContainsValue("lenkeran");

            // ---------------------------------------
            // Generic
            List<Student> listR = new List<Student>();
            Student[] arrayOfStudents = new Student[0];


            Student ziver = new Student();
            ziver.Name = "Ziver";
            listR.Add(ziver);

            Student cavid = new Student();
            cavid.Name = "Cavid";
            listR.Add(cavid);

            Student mesud = new Student();
            mesud.Name = "Mesud";
            listR.Add(mesud);

            listR.Remove(mesud);

            //listR.Add(5);
            //listR.Add(5);
            //listR.Add(6);
            //listR.Add(123);
            //listR.Add(123);

            // ADD 
            listR.Add(cavid);
            listR.AddRange(listR);

            Student ceyhun = new Student();
            listR.Insert(2, ceyhun);
            listR.InsertRange(1, listR);

            foreach (Student item in listR)
            {
                if (item.Name != "Mesud")
                {
                    listR.Remove(item);
                }
            }

            // REMOVE
            listR.Clear();
            listR.Remove(mesud);
            listR.RemoveAt(0);
            listR.RemoveRange(5, 3);
            listR.RemoveAll(x => x.Age < 15);

            // Search
            listR.IndexOf(mesud);
            listR.LastIndexOf(mesud);
            listR.Contains(mesud);
            listR.Exists(x => x.Age < 15);
            listR.Find(x => x.Age < 15);
            var a = listR.FindAll(x => x.Age < 15);
            listR.FindIndex(x => x.Age < 15);
            listR.FindLastIndex(x => x.Age < 15);
        }
    }

    class Student
    { 
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
