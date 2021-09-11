using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp{

class Program{
    static void Main(string[] args){
        int temp = 0;
        Console.WriteLine(" x(град)| x(рад.)| sin(x)");
        for (int i = 0; i <= 18; i++){
            Console.WriteLine("{0,8}|{1,8:F4}|{2,8:F4}", temp, Math.PI * temp / 180, Math.Sinh(Math.PI * temp / 180));
            temp+=10;
        }
        Console.WriteLine("author: Garkavaya NO 4207");
        System.Threading.Thread.Sleep(20000);
    }

}}