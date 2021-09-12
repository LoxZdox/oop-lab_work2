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
            lab_work_2.Class1 obj1 = new lab_work_2.Class1();
            lab_work_2.Class2 obj2 = new lab_work_2.Class2();
            lab_work_2.Class3 obj3 = new lab_work_2.Class3();

            obj1.somestrangenumber = Convert.ToInt32(Console.ReadLine());
            obj1.anothernumber = Convert.ToInt32(Console.ReadLine());
            obj1.swap(ref obj1.numberone, ref obj1.numbertwo);
            //End of lab-1
            Console.WriteLine($"Sum of numbers: {obj2.sum(ref obj2.firstnum, ref obj2.secondnum)}");
            //End of lab-2
            obj3.maxmin();

        }
    }
}