using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    public class Class1{
        public int numberone = 0;
        public int numbertwo = 0;
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
        public void swap(ref int numberone, ref int numbertwo){
            int temporary = 0;
            Console.WriteLine($"Number 1: {somestrangenumber}, number 2: {anothernumber}");
            temporary = somestrangenumber;
            somestrangenumber = anothernumber;
            anothernumber = temporary;
            Console.WriteLine($"New number 1: {somestrangenumber}, new number 2: {anothernumber}");
        }
    }
}