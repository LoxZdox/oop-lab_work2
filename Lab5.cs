using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    public class Class5
    {
        public int[] array = new int[5];
        public int this[int i]{
            get{
                return array[i];
            }
            set{
                array[i] = value;
            }
        }
        int temp = 0;
        public void sort(){
            for(int i = 0; i < 5; i++){
                array[i]=Convert.ToInt32(Console.ReadLine());
                temp = array[i];
            }
            Console.WriteLine("Here`s your elements: ");
            for(int i = 0; i < 5; i++){
                Console.Write($"{array[i]}, ");
            }
            for(int i = 0; i<5; i++){
                if(array[i]<=temp){
                    
                }
            }
        }
    }
}