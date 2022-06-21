using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class student
        {
            public int id;
           // public int age;
        }
        static void Main(string[] args)
        {
           student stu = new student();
            stu.id = 100;
            student stu2= stu;
          // stu.id = 200;

            Console.WriteLine(stu.id);
            Console.WriteLine(stu2.id);
Console.ReadLine();   
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Double x=Convert.ToDouble(Console.ReadLine());
            

            
        }
    }
}
