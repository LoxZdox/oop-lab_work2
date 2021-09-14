using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    class Class8{
        public int[] array = new int[10];
        public int this[int i]{
            get{
                return array[i];
            }
            set{
                array[i] = value;
            }
        }
        int sum = 0, aver = 0, diff = 0;
        public void findaveragest(){
            for(int i = 0; i < 10; i++){
                array[i]=Convert.ToInt32(Console.ReadLine());
                sum = sum + array[i];
                aver = aver + 1;
            }
            aver = sum/aver;
            for(int i = 0; i+1 < 10; i++){
                if((aver-array[i]>=0)&&(aver-array[i+1]>=0)){
                    if(aver-array[i]<aver-array[i+1]){
                        diff = array[i];
                        sum = i;
                    }
                }else{
                    if(aver-array[i]>=aver-array[i+1]){
                        diff = array[i];
                        sum = i;
                    }
                }
            }
            Console.WriteLine($"The averagest element is: {diff} and it`s index is {sum}");
        }
    }
}