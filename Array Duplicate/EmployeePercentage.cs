using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Duplicate
{
    public class EmployeePercentage
    {
        int NewHiredFemale = 0;
        int NewHiredmale = 0;
        int PermanentFemale = 0;
        int Permanentmale = 0;
        int ResignFemale = 0;
        int Resignmale = 0;

        int HiredEmployees = 0;
        int PermanentEmployee = 0;
        int ResignEmployee = 0;

        

        public EmployeePercentage()
        {
            HiredEmployee();
            PermananentEmployee();
            RetiredEmployee();
            totalHire();
            displayPercentage();
        }

        /// <summary>
        /// Newly Hired Employee Process
        /// </summary>
        public void HiredEmployee()
        {
            try
            {
                while (true)
                {
                    bool procOk = false;

                    /// Message
                    Console.WriteLine("What do you want to enter Hired Gender?: M, F or C: ");

                    /// Obtain user input 
                    string choice = Convert.ToString(Console.ReadLine());

                    /// Process Male employee
                    if (choice == "M")
                    {
                        /// Set proces as Not completed
                        procOk = false;
                        while (procOk == false)
                        {
                            /// Process Employee Male
                            procOk = HiredEmployeeMal();
                        }
                    }
                    /// Process Female employee
                    else if (choice == "F")
                    {
                        /// Set proces as Not completed
                        procOk = false;
                        while (procOk == false)
                        {
                            /// Process Employee Female
                            procOk = HiredEmployeeFem();
                        }
                    }
                    /// Close Process
                    else if (choice == "C")
                    {
                        /// Close process
                        break;
                    }
                }
            }
            finally
            {

            }
        }
        /// <summary>
        /// Newly Hired Employee Female
        /// </summary>
        /// <returns></returns>
        public bool HiredEmployeeFem()
        {
            bool isProcComplete = false;
            int numHired = 0;
            string userInputNum = string.Empty;

            try
            {
                /// Message
                Console.WriteLine("Enter the number of newly hired Females: ");
                /// Obtain User Input
                userInputNum = Console.ReadLine();
                /// Try to convert user input to integer
                isProcComplete = int.TryParse(userInputNum, out numHired);

                /// Cannot Convert Integer
                if (isProcComplete == false)
                {
                    /// Process again
                    HiredEmployeeFem();
                }
                else
                {
                    /// Set obtain number
                    NewHiredFemale = numHired;
                }
            }
            finally
            {

            }
            return isProcComplete;
        }
        /// <summary>
        /// Newly Hired Employee Male
        /// </summary>
        /// <returns></returns>
        public bool HiredEmployeeMal()
        {
            bool isProcComplete = false;
            int numHired = 0;
            string userInputNum = string.Empty;
            
            try
            {
                /// Message
                Console.WriteLine("Enter the number of newly hired males: ");
                /// Obtain User Input
                userInputNum = Console.ReadLine();
                /// Try to convert user input to integer
                isProcComplete = int.TryParse(userInputNum, out numHired);

                /// Cannot Convert Integer
                if (isProcComplete == false)
                {
                    /// Process again
                    HiredEmployeeMal();
                }
                else
                {
                    /// Set obtain number
                    NewHiredmale = numHired;
                }
            }
            finally
            {

            }
            return isProcComplete;
        }

        /// <summary>
        /// Permanent Employee Process
        /// </summary>
        public void PermananentEmployee()
        {
            try
            {
                while (true)
                {
                    bool procOk = false;

                    /// Message
                    Console.WriteLine("What do you want to enter Hired Gender?: M, F or C: ");

                    /// Obtain user input 
                    string choice = Convert.ToString(Console.ReadLine());

                    /// Process Male employee
                    if (choice == "M")
                    {
                        /// Set proces as Not completed
                        procOk = false;
                        while (procOk == false)
                        {
                            /// Process Employee Male
                            procOk = PermananentEmployeeMal();
                        }
                    }
                    /// Process Female employee
                    else if (choice == "F")
                    {
                        /// Set proces as Not completed
                        procOk = false;
                        while (procOk == false)
                        {
                            /// Process Employee Female
                            procOk = PermananentEmployeeFem();
                        }
                    }
                    /// Close Process
                    else if (choice == "C")
                    {
                        /// Close process
                        break;
                    }
                }
            }
            finally
            {

            }
        }
        /// <summary>
        /// Permanent Employee Female
        /// </summary>
        /// <returns></returns>
        public bool PermananentEmployeeFem()
        {
            bool isProcComplete = false;
            int numHired = 0;
            string userInputNum = string.Empty;

            try
            {
                /// Message
                Console.WriteLine("Enter the number of permanent Females: ");
                /// Obtain User Input
                userInputNum = Console.ReadLine();
                /// Try to convert user input to integer
                isProcComplete = int.TryParse(userInputNum, out numHired);

                /// Cannot Convert Integer
                if (isProcComplete == false)
                {
                    /// Process again
                    PermananentEmployeeFem();
                }
                else
                {
                    /// Set obtain number
                    PermanentFemale = numHired;
                }
            }
            finally
            {

            }
            return isProcComplete;
        }
        /// <summary>
        /// Permanent Employee Male
        /// </summary>
        /// <returns></returns>
        public bool PermananentEmployeeMal()
        {
            bool isProcComplete = false;
            int numHired = 0;
            string userInputNum = string.Empty;

            try
            {
                /// Message
                Console.WriteLine("Enter the number of permanent males: ");
                /// Obtain User Input
                userInputNum = Console.ReadLine();
                /// Try to convert user input to integer
                isProcComplete = int.TryParse(userInputNum, out numHired);

                /// Cannot Convert Integer
                if (isProcComplete == false)
                {
                    /// Process again
                    PermananentEmployeeMal();
                }
                else
                {
                    /// Set obtain number
                    Permanentmale = numHired;
                }
            }
            finally
            {

            }
            return isProcComplete;
        }

        /// <summary>
        /// Resigned Employee Process
        /// </summary>
        public void RetiredEmployee()
        {
            try
            {
                while (true)
                {
                    bool procOk = false;

                    /// Message
                    Console.WriteLine("What do you want to resigned Gender?: M, F or C: ");

                    /// Obtain user input 
                    string choice = Convert.ToString(Console.ReadLine());

                    /// Process Male employee
                    if (choice == "M")
                    {
                        /// Set proces as Not completed
                        procOk = false;
                        while (procOk == false)
                        {
                            /// Process Employee Male
                            procOk = RetiredEmployeeMal();
                        }
                    }
                    /// Process Female employee
                    else if (choice == "F")
                    {
                        /// Set proces as Not completed
                        procOk = false;
                        while (procOk == false)
                        {
                            /// Process Employee Female
                            procOk = RetiredEmployeeFem();
                        }
                    }
                    /// Close Process
                    else if (choice == "C")
                    {
                        /// Close process
                        break;
                    }
                }
            }
            finally
            {

            }
        }
        /// <summary>
        /// Resigned Employee Female
        /// </summary>
        /// <returns></returns>
        public bool RetiredEmployeeFem()
        {
            bool isProcComplete = false;
            int numHired = 0;
            string userInputNum = string.Empty;

            try
            {
                /// Message
                Console.WriteLine("Enter the number of resigned Females: ");
                /// Obtain User Input
                userInputNum = Console.ReadLine();
                /// Try to convert user input to integer
                isProcComplete = int.TryParse(userInputNum, out numHired);

                /// Cannot Convert Integer
                if (isProcComplete == false)
                {
                    /// Process again
                    RetiredEmployeeFem();
                }
                else
                {
                    /// Set obtain number
                    ResignFemale = numHired;
                }
            }
            finally
            {

            }
            return isProcComplete;
        }
        /// <summary>
        /// Resigned Employee Male
        /// </summary>
        /// <returns></returns>
        public bool RetiredEmployeeMal()
        {
            bool isProcComplete = false;
            int numHired = 0;
            string userInputNum = string.Empty;

            try
            {
                /// Message
                Console.WriteLine("Enter the number of Resigned males: ");
                /// Obtain User Input
                userInputNum = Console.ReadLine();
                /// Try to convert user input to integer
                isProcComplete = int.TryParse(userInputNum, out numHired);

                /// Cannot Convert Integer
                if (isProcComplete == false)
                {
                    /// Process again
                    RetiredEmployeeMal();
                }
                else
                {
                    /// Set obtain number
                    Resignmale = numHired;
                }
            }
            finally
            {

            }
            return isProcComplete;
        }

        /// <summary>
        /// Compute Percentage
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Total"></param>
        /// <param name="percent"></param>
        public void ComputePercentage(float Value, float Total, out float percent)
        {
            try
            {
                percent = (Value / Total) * 100;
            }
            catch (Exception)
            {
                percent =0;
            }
        }

        /// <summary>
        /// Obtain total of each Employee Department
        /// </summary>
        public void totalHire()
        {
            HiredEmployees = NewHiredmale + NewHiredFemale;
            PermanentEmployee = Permanentmale + PermanentFemale;
            ResignEmployee = Resignmale + ResignFemale;
        }

        /// <summary>
        /// Display Percentage
        /// </summary>
        /// </ Due to time Constraint I have to make it this way>
        public void displayPercentage()
        {
            float percent = 0;
            Console.WriteLine("Thank you for the Information");
            Console.WriteLine("Here is the summary");

            Console.WriteLine("Number of Hired employee {0}", HiredEmployees);

            ComputePercentage(NewHiredmale, HiredEmployees, out percent);

            Console.WriteLine("Male: {0}%", percent);

            ComputePercentage(NewHiredFemale, HiredEmployees, out percent);

            Console.WriteLine("Female: {0}%", percent);

            Console.WriteLine("Number of Permanent employee {0}", PermanentEmployee);

            ComputePercentage(Permanentmale, PermanentEmployee, out percent);

            Console.WriteLine("Male: {0}%", percent);

            ComputePercentage(PermanentFemale, PermanentEmployee, out percent);

            Console.WriteLine("Female: {0}%", percent);

            Console.WriteLine("Number of Resign employee {0}", ResignEmployee);

            ComputePercentage(Resignmale, ResignEmployee, out percent);

            Console.WriteLine("Male: {0}%", percent);

            ComputePercentage(ResignFemale, ResignEmployee, out percent);

            Console.WriteLine("Female: {0}%", percent);

        }
    }
}
