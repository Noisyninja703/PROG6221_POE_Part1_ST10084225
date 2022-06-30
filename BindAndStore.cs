using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Draft2
{
    public class BindAndStore
    {

        //Initialize Variables for bindings
        private string Taxes_Value = "";
        private string Gross_Sal_Value = "";
        private string Groceries_Value = "";
        private string Rates_Value = "";
        private string Travel_Cost_Value = "";
        private string Cell_Billing_Value = "";
        private string Rental_Value = "";
        private string Home_Price_Value = "";
        private string Home_Deposit_Value = "";
        private string Home_Interest_Value = "";
        private string Home_MonthsToRepay_Value = "";
        private string Vehicle_Make_Value = "";
        private string Vehicle_Price_Value = "";
        private string Vehicle_Deposit_Value = "";
        private string Vehicle_Interest_Value = "";
        private string Vehicle_Insurance_Value = "";
        private string OtherExpenseName_Value = "";
        private string OtherExpense_Value = "";
        
        //Static variable to allow data persistence for certain variables
        static double GrossSalaryStatic = 0;
        static double TaxAmountStatic = 0;

        static string SavingReasonStatic = "";
        static double SavingAmountStatic = 0;
        static double SavingInterestStatic = 0;
        static int SavingYearsStatic = 0;

        static string DisplaySavingReasonStatic = "";
        static double DisplaySavingAmountStatic = 0;

        //Gets And Sets on public instance of static/private variable
        public double GrossSalary
        {
            get { return GrossSalaryStatic; }
            set
            {
                if (GrossSalaryStatic != value)
                {
                    GrossSalaryStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public double TaxAmount
        {
            get { return TaxAmountStatic; }
            set
            {
                if (TaxAmountStatic != value)
                {
                    TaxAmountStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string Gross_Sal
        {
            get { return Gross_Sal_Value; }
            set
            {
                if (Gross_Sal_Value != value)
                {
                    Gross_Sal_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string Taxes
        {
            get { return Taxes_Value; }
            set
            {
                if (Taxes_Value != value)
                {
                    Taxes_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string Groceries
        {
            get { return Groceries_Value; }
            set
            {
                if (Groceries_Value != value)
                {
                    Groceries_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string Rates
        {
            get { return Rates_Value; }
            set
            {
                if (Rates_Value != value)
                {
                    Rates_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string TravelCosts
        {
            get { return Travel_Cost_Value; }
            set
            {
                if (Travel_Cost_Value != value)
                {
                    Travel_Cost_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string CellBilling
        {
            get { return Cell_Billing_Value; }
            set
            {
                if (Cell_Billing_Value != value)
                {
                    Cell_Billing_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string OtherExpenseName
        {
            get { return OtherExpenseName_Value; }
            set
            {
                if (OtherExpenseName_Value != value)
                {
                    OtherExpenseName_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string OtherExpense
        {
            get { return OtherExpense_Value; }
            set
            {
                if (OtherExpense_Value != value)
                {
                    OtherExpense_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string Rental
        {
            get { return Rental_Value; }
            set
            {
                if (Rental_Value != value)
                {
                    Rental_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string HomePrice
        {
            get { return Home_Price_Value; }
            set
            {
                if (Home_Price_Value != value)
                {
                    Home_Price_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string HomeDeposit
        {
            get { return Home_Deposit_Value; }
            set
            {
                if (Home_Deposit_Value != value)
                {
                    Home_Deposit_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string HomeInterest
        {
            get { return Home_Interest_Value; }
            set
            {
                if (Home_Interest_Value != value)
                {
                    Home_Interest_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string HomeMonthsToRepay
        {
            get { return Home_MonthsToRepay_Value; }
            set
            {
                if (Home_MonthsToRepay_Value != value)
                {
                    Home_MonthsToRepay_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string VehicleMake
        {
            get { return Vehicle_Make_Value; }
            set
            {
                if (Vehicle_Make_Value != value)
                {
                    Vehicle_Make_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string VehiclePrice
        {
            get { return Vehicle_Price_Value; }
            set
            {
                if (Vehicle_Price_Value != value)
                {
                    Vehicle_Price_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string VehicleDeposit
        {
            get { return Vehicle_Deposit_Value; }
            set
            {
                if (Vehicle_Deposit_Value != value)
                {
                    Vehicle_Deposit_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string VehicleInterest
        {
            get { return Vehicle_Interest_Value; }
            set
            {
                if (Vehicle_Interest_Value != value)
                {
                    Vehicle_Interest_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string VehicleInsurance
        {
            get { return Vehicle_Insurance_Value; }
            set
            {
                if (Vehicle_Insurance_Value != value)
                {
                    Vehicle_Insurance_Value = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string SavingReason
        {
            get { return SavingReasonStatic; }
            set
            {
                if (SavingReasonStatic != value)
                {
                    SavingReasonStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public double SavingAmount
        {
            get { return SavingAmountStatic; }
            set
            {
                if (SavingAmountStatic != value)
                {
                    SavingAmountStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public double SavingInterest
        {
            get { return SavingInterestStatic; }
            set
            {
                if (SavingInterestStatic != value)
                {
                    SavingInterestStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public int SavingYears
        {
            get { return SavingYearsStatic; }
            set
            {
                if (SavingYearsStatic != value)
                {
                    SavingYearsStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public string DisplaySavingReason
        {
            get { return DisplaySavingReasonStatic; }
            set
            {
                if (DisplaySavingReasonStatic != value)
                {
                    DisplaySavingReasonStatic = value;
                }
            }
        }

        //Gets And Sets on public instance of static/private variable
        public double DisplaySavingAmount
        {
            get { return DisplaySavingAmountStatic; }
            set
            {
                if (DisplaySavingAmountStatic != value)
                {
                    DisplaySavingAmountStatic = value;
                }
            }
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

