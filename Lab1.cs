using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_2
{
    class Class1{
        public string name;
        public int age;
        public readonly string text;
        public Class1(){
            age = 18;
            name = "Peter";
            text = " He lives in a small town.";
        }
        public Class1(int newage){
            age = newage;
            name = "Peter";
            text = " He lives in a small town.";
        }
        public Class1(int newage, string newname){
            age = newage;
            name = newname;
            text = " He lives in a big town.";
        }
    }
}