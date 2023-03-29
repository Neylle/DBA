using Array_Duplicate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBA_Coding_Exam
{
    public class ArrayDuplicate
    {
        /// <summary>
        /// Duplicate Array
        /// </summary>
        /// <Disc>
        /// To print a the duplicated numbers in an array
        /// </Disc>
        /// <Created by L.Dela Cruz Jr 03/29/23>
        public static void DupArray()
        { 
            string    duplString = string.Empty;            /// Sting with duplicated numbers
            List<int> duplicates = new List<int>();         /// List of Integer with duplicated numbers

            /// Number array based on Question
            int[] NumArray = { 5, 1, 4, 6, 7, 3, 5, 7, 3 };

            /// Group records in Array, then obtain data if there group count is Higher than 1.
            duplicates = NumArray.GroupBy(Num => Num)
                          .Where(GroupCount => GroupCount.Count() > 1)
                          .Select(SelRec => SelRec.Key)
                          .ToList();
            /// Join list with ","
            duplString = String.Join(", ", duplicates);

            /// Print the output
            Console.WriteLine(duplString);

        }
    }
}
