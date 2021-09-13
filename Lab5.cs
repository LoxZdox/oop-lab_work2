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
        int temp = 0, min = 0, max = 0;
        public void sort(){
            for(int i = 0; i < 5; i++){
                array[i]=Convert.ToInt32(Console.ReadLine());
                temp = array[i];
                max = array[i];
                min = array[i];
            }
            Console.WriteLine("Here`s your elements: ");
            for(int i = 0; i < 5; i++){
                Console.Write($"{array[i]}, ");
                if(max<=array[i]){
                    max = array[i];
                }
                if(min>=array[i]){
                    min = array[i];
                }
            }
            //This is bubble sort, so the second cycle is for the worst scenario. O(n^2)
            for(int j = 0; j < 5; j++){
                for(int i = 0; i+1 < 5; i++){
                    if(array[i]>=array[i+1]){
                        temp = array[i];
                        array[i] = array[i+1];
                        array[i+1] = temp;
                    }
                }
            }
            Console.WriteLine("Here`s your sorted elements: ");
            for(int i = 0; i < 5; i++){
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"\nMax integer: {max}, min integer: {min}");
        }
    }
}