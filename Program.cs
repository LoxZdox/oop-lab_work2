using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Console.WriteLine($"He`s {obj1.age} years old, his name is {obj1.name}.{obj1.text}");
            Class1 obj12 = new Class1(13);
            Console.WriteLine($"He`s {obj12.age} years old, his name is {obj12.name}.{obj12.text}");
            Class1 obj13 = new Class1(13, "Damir");
            Console.WriteLine($"He`s {obj13.age} years old, his name is {obj13.name}.{obj13.text}");
        }
    }
}