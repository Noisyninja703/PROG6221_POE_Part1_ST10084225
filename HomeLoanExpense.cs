using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part_1
{

    class HomeLoanExpense : Expenses
    {

        //**************************************************************      Declare Variables      *****************************************************************************************

        //Initialize variables
        private double thirdOfGrossSalary;
        private double homePurchasePrice;
        private double homeTotalDeposit;
        private double annualInterestRate;
        private int monthsToRepay;
        public double monthlyAmount;

        //**************************************************************      Get And Set Methods      *****************************************************************************************

        //Create Get and Set methods
        public double ThirdOfGrossSalary { get => thirdOfGrossSalary; set => thirdOfGrossSalary = value; }
        public double PurchasePrice { get => homePurchasePrice; set => homePurchasePrice = value; }
        public double TotalDeposit { get => homeTotalDeposit; set => homeTotalDeposit = value; }
        public double InterestRate { get => annualInterestRate; set => annualInterestRate = value; }
        public int RepayMonths { get => monthsToRepay; set => monthsToRepay = value; }

        //**************************************************************      Calc Monthly Bond      *****************************************************************************************

        //Create the CalcMonthlyBond method
        public double CalcMonthlyBond()
        {    

            //Calculate the monthly payment amount
     
            monthlyAmount = Math.Round((homePurchasePrice - homeTotalDeposit) * (1 + (annualInterestRate / 100) * (RepayMonths / 12)) / 12, 2); //All calculations are done during the runtime, this helps reduce the need to assign memory to more variables

        //Print the monthly payment amount
            Console.WriteLine("\n*****************************************************************\n\n" + 
                              "Your Monthly Home Loan Repayment is: R" + monthlyAmount + "\n");

        //If, the monthly payment is greater than a third of the user's gross salary, give them a warning
            if (monthlyAmount > (thirdOfGrossSalary))
            {               
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Approval Of The Home Loan Is Unlikely");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your Home Loan Is Likely To Be Approved");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }
            return monthlyAmount;

        }

        //**************************************************************      Home Loan Expense Calculate Expense      *****************************************************************************************

        //Override the CalculateExpense method for HomeLoanExpense, too calc the surplus amount after expenses when buying property
        public override void CalculateExpense(double salary, double expenses, double taxAmount, double accommodation)
        {

            availAmount = salary - (taxAmount + expenses + accommodation);
          
        }

    }
}


//███▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//██████▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░
//██████████▓▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░
//███████████████▓▓▒▒▒░░░░─░░░─░──░░░░░░░░
//█████▓▒▒▒▓▓▓███▓██▓▓▒▒▒░░─░─────────────
//███▓▒░░░░░▒▒▓█████████▓▒▒▒░░─────░──────
//███▒▒░░░░─░░░▒▓█████████▓▓▒▒▒░░─────────
//████▓▓▒▒░░░────░▒▓▓██████████▓▒▒▒░░░────
//███████▓▓▓▒░░░─────░▒▒▓██████████▓▓▒░░░─
//████████████████▓▒▒░──░▒▒▒▓█████████▓▒░░
//█████████████████████▓▓▓▓▒░─░░▒▓▓▓▓▓▓▒▒░
//████████████████████████████▓▒░░░░░░░░──
//███████████████████████████████▒────────
//██████████████▓▓▒▒███▓███████████▒──────
//████████████▒░───░██▓▓█████▓███████░────
//████████████▒────░███▓█████▓██▓░▓███▒───
//█████████████░────▒██▓▓██▓███▓░──░███▓──
//██████████████─────▒████████▒─────▒████─
//███████████████▒─────▓████▓──────▒▓████▒
//█████████████████▓▒──────────▒▓████████▓
//█████████████████████▓▓▓▓▓▓████████████▒
//█████████▓▓▓▒▓▓▓███████████████████████▒
//███▓████▓▒░─────░░███████████▓▓▓▓▓▓▒░░░─
//██▓▓███▒░░─────────▓████████▒░░▒▒▒░░░───
//██▓███▓░░───────────███████▓░░░░░░░─────
//██▓███░────────░────▓██████▒────────────
//█▓▓██▓─────────▓────▓█████▓░────────────
//█▓▓██░─────────█▒───▓█████▒─────────────
//█▓▓██──────────█▒───▓█████░─────────────
//█▓▓██─────────░█────▒█████──────────────
//█▓▒██─────────█░────░████▓──────────────
//█▓░▓█▓──────░█▒──────████▒──────────────
//█▓░░███░─░▒▓█▒───────████▒──────────────
//██▒─░██████▓─────────████░──────────────
//██▓░─────────────────▓███░──────────────
//██▓▒───Developed By──▒███░──────────────
//██▓▒░──Sivan Moodley─░███───────────────
//███▓░────ST10084225───███───────────────
//███▓░░────────────────██▓───────────────
//████▒░────────────────▓█▓───────────────
//████▓░────────────────▓█▒───────────────
//█████▒────────────────▒█▒───────────────
//█████▒────────────────▒█▒───────────────
//██████░───────────────▒█▒───────────────
//██████▒───────────────▒█░───────────────
//██████▓░──────────────░▓░───────────────
//███████▒──────────────░▓▒───────────────
//████████░──────────────▓▒───────────────
//████████▓░─────────────▒▒───────────────
//█████████▒─────────────▒▒───────────────
//██████████▒────────────▒░───────────────
//███████████▒───────────▒░───────────────
//███████████▓▒──────────░░───────────────
//█████████████▒─────────░░───────────────
//█████████████▓▒░────────────────────────



