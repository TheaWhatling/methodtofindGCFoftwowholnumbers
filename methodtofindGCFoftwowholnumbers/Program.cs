using System;

namespace methodtofindGCFoftwowholnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Temp1;
            int Temp2;
            string Result;

            Console.WriteLine("please enter a whole number");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter another whole number");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Temp1 = Num1;
            Temp2 = Num2;

            while (Temp1 != Temp2)
            {
                if (Temp1 > Temp2)
                {
                    Temp1 = Temp1 - Temp2;
                }
                else
                {
                    Temp2 = Temp2 - Temp1;
                }
            }

            Result = Convert.ToString(Temp1);
  
            Console.WriteLine(Result, ", is a GCF of ", Num1, " and ", Num2);
        }
    }
}
