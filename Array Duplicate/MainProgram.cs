using DBA_Coding_Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Duplicate
{
    public class MainProgram
    {
        static void Main(string[] args)
        {

            bool isStop = false;

            while (true)
            {
                isStop = Choice();

                if (isStop == false)
                {
                    
                    break;
                }
            }
        }

        public static bool Choice()
        {
            bool isStop = true;
            try
            {
                /// Choose what you want to do
                Console.WriteLine("[1] Duplicate Array, [2] Number Triangle [3] Employee Percentage");
                Console.WriteLine("Please choose what to do: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    ArrayDuplicate.DupArray();
                }
                else if (n == 2)
                {
                    NumTriangle.NumbTriangle();
                }
                else if (n == 3)
                {
                    EmployeePercentage employeePercentage = new EmployeePercentage();
                }
                else if (n == 4)
                {
                    isStop = false;
                }
                else
                {
                    /// Repeat
                }
            }
            finally 
            { 
                isStop = false; 
            }
            return isStop;
        }
    }
}
