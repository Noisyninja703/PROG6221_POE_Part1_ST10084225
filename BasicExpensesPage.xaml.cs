using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PROG6221_POE_Draft2
{

    public partial class BasicExpensesPage : Page
    {
        //Instantiate onjects for binding and initialize variables 

        BindAndStore bs = new BindAndStore();
        PopulateDictionary populateDict = new PopulateDictionary();
        HomeLoanExpense hmln = new HomeLoanExpense();
        bool salaryValid = false;
        bool taxesValid = false;
        bool groceriesValid = false;
        bool ratesValid = false;
        bool travelCostValid = false;
        bool cellBillingValid = false;
        bool otherExpenseNameValid = false;
        bool otherExpenseValid = false;
        double grossSalary = 0;


        public BasicExpensesPage()
        {

            //DataContext
            this.DataContext = bs;
            InitializeComponent();

        }

        //Button Clicked
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            //Validate input
            if (!double.TryParse(bs.Gross_Sal, out grossSalary))
            {

                grossSalaryInput.Text = "Invalid Input";
                salaryValid = false;
            }
            else
            {

                grossSalaryInput.Text = "Saved Successfully";
                salaryValid = true;
                bs.GrossSalary = grossSalary;
                hmln.ThirdOfGrossSalary = grossSalary / 3;

            }

            //Validate input
            double taxes = 0;


            if (!double.TryParse(bs.Taxes, out taxes))
            {

                taxesInput.Text = "Invalid Input";
                taxesValid = false;
            }
            else
            {

                taxesInput.Text = "Saved Successfully";
                taxesValid = true;
                bs.TaxAmount = taxes;

            }

            //Validate input
            double groceries = 0;


            if (!double.TryParse(bs.Groceries, out groceries))
            {

                groceriesInput.Text = "Invalid Input";
                groceriesValid = false;
            }
            else
            {

                groceriesInput.Text = "Saved Successfully";
                groceriesValid = true;

            }

            //Validate input
            double rates = 0;


            if (!double.TryParse(bs.Rates, out rates))
            {

                ratesInput.Text = "Invalid Input";
                ratesValid = false;
            }
            else
            {

                ratesInput.Text = "Saved Successfully";
                ratesValid = true;

            }

            //Validate input
            double travelCosts = 0;


            if (!double.TryParse(bs.TravelCosts, out travelCosts))
            {

                travelInput.Text = "Invalid Input";
                travelCostValid = false;
            }
            else
            {

                travelInput.Text = "Saved Successfully";
                travelCostValid = true;

            }

            //Validate input
            double cellBilling = 0;


            if (!double.TryParse(bs.CellBilling, out cellBilling))
            {

                cellBillingInput.Text = "Invalid Input";
                cellBillingValid = false;
            }
            else
            {

                cellBillingInput.Text = "Saved Successfully";
                cellBillingValid = true;

            }

            //Check that all fields have being filled, no null values
            if ((salaryValid == true) && (taxesValid == true) && (groceriesValid == true) && (ratesValid == true) && (travelCostValid == true) && (cellBillingValid == true)) 
            {

                //Populate dictionary
                populateDict.dictExpenses.Add("Groceries", groceries);
                populateDict.dictExpenses.Add("Water And Lights", rates);
                populateDict.dictExpenses.Add("Travel Costs(Including Fuel)", travelCosts);
                populateDict.dictExpenses.Add("Telephone And Cellphone Billing", cellBilling);
                
            }

            double currentExpense = populateDict.sumDict();
            double currentSurplus = (grossSalary - bs.TaxAmount) - currentExpense;

            MessageBox.Show(currentExpense.ToString() + " " + currentSurplus.ToString());

            if (((otherExpenseNameValid == true) && (otherExpenseValid == true) && (salaryValid == true) && (taxesValid == true) && (groceriesValid == true) && (ratesValid == true) && (travelCostValid == true) && (cellBillingValid == true)) || ((otherExpenseNameValid == false) && (otherExpenseValid == false) && (salaryValid == true) && (taxesValid == true) && (groceriesValid == true) && (ratesValid == true) && (travelCostValid == true) && (cellBillingValid == true)))
                if ((currentSurplus >= grossSalary * 0.8) &&(currentSurplus <= grossSalary))
                {

                    StackGreat.Visibility = Visibility.Visible;
                    StackGood.Visibility = Visibility.Hidden;
                    StackBad.Visibility = Visibility.Hidden;

                }

            if ((currentSurplus >= grossSalary * 0.6) && (currentSurplus <= grossSalary * 0.79))
            {

                StackGood.Visibility = Visibility.Visible;
                StackGreat.Visibility = Visibility.Hidden;
                StackBad.Visibility = Visibility.Hidden;

            }

            if ((currentSurplus >= 0) && (currentSurplus <= grossSalary * 0.59))
            {

                StackBad.Visibility = Visibility.Visible;
                StackGood.Visibility = Visibility.Hidden;
                StackGreat.Visibility = Visibility.Hidden;

            }

        }

        //Button Clicked - Other Expenses
        private void AddExpense_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            //Validate input
            string otherExpenseName = bs.OtherExpenseName;

            if (string.IsNullOrEmpty(otherExpenseName))
            {

                otherExpenseNameInput.Text = "Invalid Input";
                otherExpenseNameValid = false;
            }
            else
            {

                otherExpenseNameInput.Text = "Saved Successfully";
                otherExpenseNameValid = true;
              
            }

            //Validate input
            double otherExpense = 0;


            if (!double.TryParse(bs.OtherExpense, out otherExpense))
            {

                otherExpenseInput.Text = "Invalid Input";
                otherExpenseValid = false;
            }
            else
            {

                otherExpenseInput.Text = "Saved Successfully";
                otherExpenseValid = true;

            }

            //Check that all fields have being filled, no null values
            if ((otherExpenseNameValid == true) && (otherExpenseValid == true))
            {
                //Populate dictionary
                populateDict.dictExpenses.Add(otherExpenseName, otherExpense);

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
