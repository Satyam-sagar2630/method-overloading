using System;
namespace app
{
    class Program
    {
        static int plusint(int x,int y)
        {
            return x + y;
        }
        static double plusint(double x,double y)
        {
            return x + y;
        }
        static void Main(string[]qrg)
        {
            int num1=plusint(3,4);
            double num2=plusint(5.56,6.48);
            Console.WriteLine("int "+num1);
            Console.WriteLine("double " + num2);



        }

        

    }
}