using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    public class Class1{
        int numberone = 0;
        int numbertwo = 0;
        public int somestrangenumber{
            get{
                return numberone;
            }
            set{
                numberone = value;
            }
        }
        public int anothernumber{
            get{
                return numbertwo;
            }
            set{
                numbertwo = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int temporary = 0;
            Class1 obj = new Class1();
            obj.somestrangenumber = Convert.ToInt32(Console.ReadLine());
            obj.anothernumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number 1: {obj.somestrangenumber}, number 2: {obj.anothernumber}");
            temporary = obj.somestrangenumber;
            obj.somestrangenumber = obj.anothernumber;
            obj.anothernumber = temporary;
            Console.WriteLine($"New number 1: {obj.somestrangenumber}, new number 2: {obj.anothernumber}");
        }
    }
}
