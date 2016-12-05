using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    class Group
    {
        
        public static Random rnd = new Random();
        

        public static void InputPerson(out Student n)
        {
            n = new Student(); 
           n.Year = 1997 + rnd.Next(-2, 2);
           n.Name = "Student";
           n.IndividualCode = rnd.Next(10, 99);
           n.Subject1 = "Mathematic";
           n.Subject_1_Ball = rnd.Next(1, 5);
           n.Subject2 = "Phythic";
           n.Subject_2_Ball = rnd.Next(1, 5);
           n.Subject3 = "Something";
           n.Subject_3_Ball = rnd.Next(1, 5);
        }

        public static void PrintPerson(Student n)
        {
            Console.WriteLine("{0} {1} IndividualCode: {2}", n.Name, n.Year, n.IndividualCode);
        }

        public static void Prints2(Student n)
        {
              

            Console.WriteLine("\t {0} {1} [{2}] - {3},", n.Subject1, n.Name, n.IndividualCode, n.Subject_1_Ball);
            Console.WriteLine("\t {0} {1} [{2}] - {3}", n.Subject2, n.Name, n.IndividualCode, n.Subject_2_Ball);
            Console.WriteLine("\t {0} {1} [{2}] - {3}", n.Subject3, n.Name, n.IndividualCode, n.Subject_3_Ball);
            Console.WriteLine();

            Console.WriteLine("Ball = {0}",Set(n));


        }

        public static double Set(Student n)
        {
            return (n.Subject_1_Ball + n.Subject_2_Ball + n.Subject_3_Ball) / 3;
        }

        public static void PrintPersons(Student[] n)
        {
            foreach (var item in n)
            {
                PrintPerson(item);
            }
            foreach (var item in n)
            {
                Prints2(item);
            }

        }

    

        public  void Func ()
        {
            Student[] department = new Student[3];

                for (int i = 0; i < department.Length; i++)
                {
                    InputPerson(out department[i]);
                }

                PrintPersons(department);

                Console.ReadKey();
        }


       
    }
}
