using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    public class Class4{
        public int[] array = new int[5];
        public int this[int i]{
            get{
                return array[i];
            }
            set{
                array[i] = value;
            }
        }
        int sum = 0;
        int aver = 0;
        public int sumof{
            get{
                return sum;
            }
        }
        public int averof{
            get{
                return aver;
            }
        }
        public void sumaver()
        {
            for(int i = 0; i < 5; i++){
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + array[i];
                aver = aver + 1;
            }
            aver = sum/aver;
            Console.WriteLine("Here`s your elements: ");
            for(int i = 0; i < 5; i++){
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"\nSum of elements: {sum}, aver value of elements: {aver}.");
        }
    }
}