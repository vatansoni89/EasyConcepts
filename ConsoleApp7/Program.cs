using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Bank
    { 
        public void GenAccNo()
        { 
            Console.WriteLine("Bank");
        }
    }
    class LotteryAcc: Bank
    { 
        public void GenAccNo()
        { 
            Console.WriteLine("Lottery");
        }
        
        public void Hii()
        { 
            Console.WriteLine("Hii");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b ;
            LotteryAcc l = new LotteryAcc();
            b=l;
            b.GenAccNo();
            Console.ReadKey();
            //// The code provided will print ‘Hello World’ to the console.
            //// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            //// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
