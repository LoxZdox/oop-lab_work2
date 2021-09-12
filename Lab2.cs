using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    public class Class2{
        public int firstnum = 5;
        public int secondnum = 9;
        public int firstprop{
            get{
                return firstnum;
            }
            set{
                firstnum = value;
            }
        }
        public int secondprop{
            get{
                return secondnum;
            }
            set{
                secondnum = value;
            }
        }
        public int sum(ref int firstnum, ref int secondnum){
            int sum = firstnum + secondnum;
            return sum;
        }
    }
}