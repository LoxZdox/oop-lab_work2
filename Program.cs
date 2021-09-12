using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{

    public class Class1{
        public int age1;
        public int age2;
        public string name;

        public Class1(int age, string name) {
            this.name = name;
            this.age1 = age1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ob1 = new Class1(5, "Даня");
            Console.WriteLine("Сколько тебе лет?");
            ob1.age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("А тебе?");
            ob1.age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{ob1.name} малявка, потому что ему {ob1.age1} лет.");
            Console.WriteLine($"{ob2.name} старушька- пердушька {ob1.age2}-ти летняя.");
        }
    }
}
