using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Duplicate
{
    internal class NumTriangle
    {
        /// <summary>
        /// Number Triangle
        /// </summary>
        /// <Disc>
        /// To print a triangle with the current number row 
        /// is the displayed row
        /// </Disc>
        /// <Created by L.Dela Cruz Jr 03/29/23>
        public static void NumbTriangle()
        {
            int CurrRow = 0;    /// Current row being processed
            int CurrColl = 0;    /// Current collumn being processed
            int MaxRow = 0;    /// Maximum rows to be created

            /// Title
            Console.Write("Print the Number's Triangle:\n");

            /// Input total number of rows
            Console.Write("Input number of rows : ");

            /// Set the total number of rows
            MaxRow = Convert.ToInt32(Console.ReadLine());

            /// Loop on how many rows will be printed
            for (CurrRow = 1; CurrRow <= MaxRow; CurrRow++)
            {
                /// loop on how many collumns will be printed
                for (CurrColl = 1; CurrColl <= CurrRow; CurrColl++)
                {
                    /// print the number
                    Console.Write("{0}", CurrRow);
                }

                /// Break to the next line
                Console.Write("\n");
            }
        }
    }
}
