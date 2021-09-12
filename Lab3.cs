using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    public class Class3{
        public int[] firstarray = new int[5];
        public int this[int i]{
            get{
                return firstarray[i];
            }
            set{
                firstarray[i] = value;
            }
        }
        public void maxmin()
        {
            int max = 0 ,min = 0;
            for(int i = 0; i < 5; i++){
                firstarray[i] = Convert.ToInt32(Console.ReadLine());
                if(max<=firstarray[i]){
                    max = firstarray[i];
                }
                if(min>=firstarray[i]){
                    min = firstarray[i];
                }
            }
            Console.WriteLine("Ты умничка.");
        }
    }
}