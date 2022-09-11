using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._4
{
     class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students3A, students3B;

            students3A = new string[5] {  "Geeta", "Ram", "Aryan", "Gopal", "Sita" };
            students3B = new string[5] {  "Sukhwinder", "Gopi", "Ragini", "Babu", "James" };

            string[] subjects = new string[4];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "English";
            

            int[] marks = new int[4];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 80;
            marks[3] = 55;
           

            Console.WriteLine("Students of Class 3A:");
            foreach (string s in students3A)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students of Class 3B:");
            foreach (string s in students3B)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Ram:");
            int total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/400 = " + (total * 100 / 400) + " percent");
        }
    }
}
