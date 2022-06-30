using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace PROG6221_POE_Draft2
{
    public partial class BudgetReport : Page
    {

        //Instantiate onjects for binding and initialize variables
        BindAndStore bs = new BindAndStore();
        PopulateDictionary populateDict = new PopulateDictionary();
        HomeLoanExpense hmln = new HomeLoanExpense();
        RentalExpense rental = new RentalExpense();
        HomeExpensesPage homeExp = new HomeExpensesPage();
        CarLoanExpense car = new CarLoanExpense();
        CarExpense carExp = new CarExpense();

        //KeySearch Delegate Creation
        public delegate void notifyUser(double rentalExpense, double hmlnExpense, double carExpense);


        public double TotalAmount = 0;

        public BudgetReport()
        {
            //DataContext
            this.DataContext = bs;
            InitializeComponent();

        }

        //Button Clicked
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //Create some values to help streamline the Delegate Later 
            double rentalExpense = Math.Round(rental.AvailAmount, 2);
            double hmlnExpense = Math.Round(hmln.AvailAmount, 2);
            double carExpense = Math.Round(car.carAvailAmount, 2);

            //Use If statements to find the current combo of calculations needed
            if (!carExp.CarCheck)
            {

                TotalAmount = Math.Round(hmln.AvailAmount, 2);

                if (!homeExp.HomeSelected)
                {

                    TotalAmount = Math.Round(rental.AvailAmount, 2);

                }
            }

            else

            {

                //Use If statements to find the current combo of calculations needed
                if (carExp.CarCheck)
                {

                    if (!homeExp.RentalSelected)
                    {

                        //call car expense calc and populate dictionary
                        car.CarCalcExpense(hmln.AvailAmount, car.MonthlyCost);
                        populateDict.dictExpenses.Add(car.ModelAndMake + " " + "Monthly Payments", car.MonthlyCost);
                        TotalAmount = Math.Round(car.carAvailAmount, 2);



                        if (!homeExp.HomeSelected)
                        {

                            //call car expense calc and populate dictionary
                            car.CarCalcExpense(rental.AvailAmount, car.MonthlyCost);
                            populateDict.dictExpenses.Add(car.ModelAndMake + " Monthly Payments", car.MonthlyCost);
                            TotalAmount = Math.Round(car.carAvailAmount, 2);

                        }

                    }

                }
            }


                //Sort the dictionary in descending order based on the "value" amount 
                populateDict.dictExpenses = populateDict.dictExpenses.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                //Add Header text to the rich textbox
                richTextDisplay.AppendText("********************************************************\n");
                richTextDisplay.AppendText("                   Your Budget Report                  \n");
                richTextDisplay.AppendText("********************************************************\n");

                richTextDisplay.AppendText("\n*******************************************************\n");
                richTextDisplay.AppendText("                   Your Income This Month              \n");
                richTextDisplay.AppendText("********************************************************\n");

                richTextDisplay.AppendText("Your Gross Income: R" + bs.GrossSalary + "\n");
                richTextDisplay.AppendText("Your Monthly Taxes: R" + bs.TaxAmount + "\n");
                richTextDisplay.AppendText("Your Income After Taxes: R" + (bs.GrossSalary - bs.TaxAmount) + "\n");

                richTextDisplay.AppendText("\n*******************************************************\n");
                richTextDisplay.AppendText("                  Your Expenses This Month              \n");
                richTextDisplay.AppendText("********************************************************\n");


                //Print the expenses from the dictionary to the rich textbox in descending Order
                foreach (KeyValuePair<string, double> pair in populateDict.dictExpenses)
                {
                    richTextDisplay.AppendText(pair.Key + ": R" + pair.Value + "\n");

                }

                //Print the total monthly expenses to the rich textbox
                richTextDisplay.AppendText("\n*******************************************************\n");
                richTextDisplay.AppendText("                  Total Expenses: R" + populateDict.sumDict() + "\n");
                richTextDisplay.AppendText("********************************************************\n");

                //KeySearch 75% Delegate Instantiation
                notifyUser del_notifyuser = new notifyUser(NotifyUser);

                //KeySearch 75% Delegate Invocation
                del_notifyuser(rentalExpense, hmlnExpense, carExpense);

            

       
        }

        //Delegate to warn the user if 75% or more of their salary is used by their expenses
        public void NotifyUser(double rentalExpense, double hmlnExpense, double carExpense)
        {


            //Create an int to use as a keyword for a switch
            int menuOption = 0;

            //Check how much of the user's gross salary is left over after expenses relative to percentage


            if (!carExp.CarCheck && hmlnExpense >= bs.GrossSalary * 0.60 && hmlnExpense <= bs.GrossSalary) { menuOption = 1; }

            if (!carExp.CarCheck && hmlnExpense >= bs.GrossSalary * 0.33 && hmlnExpense <= bs.GrossSalary * 0.6) { menuOption = 2; }

            if (!carExp.CarCheck && hmlnExpense > 0 && hmlnExpense <= bs.GrossSalary * 0.25) { menuOption = 3; }

            if (!carExp.CarCheck && hmlnExpense < 0) { menuOption = 4; }



            if (!carExp.CarCheck && rentalExpense >= bs.GrossSalary * 0.60 && rentalExpense <= bs.GrossSalary) { menuOption = 5; }

            if (!carExp.CarCheck && rentalExpense >= bs.GrossSalary * 0.33 && rentalExpense <= bs.GrossSalary * 0.6) { menuOption = 6; }

            if (!carExp.CarCheck && rentalExpense > 0 && rentalExpense <= bs.GrossSalary * 0.25) { menuOption = 7; }

            if (!carExp.CarCheck && rentalExpense < 0) { menuOption = 8; }


            if (carExp.CarCheck && (carExpense >= bs.GrossSalary * 0.60 && carExpense <= bs.GrossSalary)) { menuOption = 9; }

            if (carExp.CarCheck && (carExpense >= bs.GrossSalary * 0.33 && carExpense <= bs.GrossSalary * 0.6)) { menuOption = 10; }

            if (carExp.CarCheck && (carExpense > 0 && carExpense <= bs.GrossSalary * 0.25)) { menuOption = 11; }

            if (carExp.CarCheck && (carExpense < 0)) { menuOption = 12; }

            //If, rental was not chosen, apply calc using HomeLoanExpense, Else, Use rentalExpense
            //Else if, Displays the amount available after calculations in different colours based of what percentage of the gross salary is left
            // Green - More than 60% // Yellow - More than 33% // Dark Yellow - Less than 25% // Dark Red - Less than 0%
            switch (menuOption)
            {
                case 1:

                    //Surplus amount > 60% of gross salary
                    MessageBox.Show("60% Or More Of Your Salary Left Over");

                    break;

                case 2:

                    //Surplus amount > 33% of gross salary
                    MessageBox.Show("33% Or More Of Your Salary Left Over");

                    break;


                case 3:

                    MessageBox.Show("Warning More Than 75% Of Your Salary Wil Be Spent" + "\n 25% Or less Of Your Salary Left Over");

                    break;


                case 4:

                    //Surplus amount < 0% of gross salary
                    MessageBox.Show("Warning More Than 100% Of Your Salary Wil Be Spent" + "\n You Are In Debt");

                    break;

                case 5:

                    //Surplus amount > 60% of gross salary
                    MessageBox.Show("60% Or More Of Your Salary Left Over");
                    break;

                case 6:

                    //Surplus amount > 33% of gross salary
                    MessageBox.Show("33% Or More Of Your Salary Left Over");
                    break;

                case 7:

                    //Surplus amount < 25% of gross salary
                    MessageBox.Show("Warning More Than 75% Of Your Salary Wil Be Spent" + "\n 25% Or less Of Your Salary Left Over");

                    break;

                case 8:

                    //Surplus amount < 0% of gross salary
                    MessageBox.Show("Warning More Than 100% Of Your Salary Wil Be Spent" + "\n You Are In Debt");

                    break;

                case 9:

                    //Surplus amount > 60% of gross salary
                    MessageBox.Show("60% Or More Of Your Salary Left Over");
                    break;

                case 10:

                    //Surplus amount > 33% of gross salary
                    MessageBox.Show("33% Or More Of Your Salary Left Over");

                    break;

                case 11:

                    //Surplus amount < 25% of gross salary
                    MessageBox.Show("Warning More Than 75% Of Your Salary Wil Be Spent" + "\n 25% Or less Of Your Salary Left Over");

                    break;

                case 12:

                    //Surplus amount < 0% of gross salary
                    MessageBox.Show("Warning More Than 100% Of Your Salary Wil Be Spent" + "\n You Are In Debt");
                    break;
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


