using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    class Class9{
        public int[] array = new int[5];
        public int this[int i]{
            get{
                return array[i];
            }
            set{
                array[i] = value;
            }
        }
        public int[] fill(){
            for(int i = 0; i < 5; i++){
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
    }
}