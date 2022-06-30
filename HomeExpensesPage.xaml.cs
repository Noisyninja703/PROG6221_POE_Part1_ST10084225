using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PROG6221_POE_Draft2
{

    public partial class HomeExpensesPage : Page
    {

        //Instantiate onjects for binding and initialize variables 
        BindAndStore bs = new BindAndStore();
        RentalExpense rental = new RentalExpense();
        HomeLoanExpense hmln = new HomeLoanExpense();
        PopulateDictionary populateDict = new PopulateDictionary();
        BasicExpensesPage basicExpensesPage = new BasicExpensesPage();
        bool rentalValid = false;
        bool homePriceValid = false;
        bool homeDepositValid = false;
        bool homeInterestValid = false;
        bool homeMonthsToRepayValid = false;

        static bool rentalSelected = false;
        static bool homeSelected = true;

        //Gets And Sets on public instance of static/private variable
        public bool RentalSelected { get { return rentalSelected; } set { rentalSelected = value; } }
        public bool HomeSelected { get { return homeSelected; } set { homeSelected = value; } }

        public HomeExpensesPage()
        {
            //DataContext
            this.DataContext = bs;
            InitializeComponent();

        }


        //Button Clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string rentalCheck = bs.Rental;
            string homeCheck = bs.HomePrice;

            //Validate input
            if (RentalSelected == true)
            {

                double rent = 0;


                if (!double.TryParse(bs.Rental, out rent))
                {

                    rentInput.Text = "Invalid Input";
                    rentalValid = false;
                }
                else
                {

                    rentInput.Text = "Saved Successfully";
                    rentalValid = true;

                    //Call the rental overrided calculate method
                    rental.CalculateExpense(bs.GrossSalary, populateDict.sumDict(), bs.TaxAmount, rent);

                    //Populate dictionary
                    populateDict.dictExpenses.Add("Monthly Rental", rent);

                }

            }

            //Validate input
            if (HomeSelected == true)
            {

                //Validate input
                double homePrice = 0;


                if (!double.TryParse(bs.HomePrice, out homePrice))
                {

                    propPriceInput.Text = "Invalid Input";
                    homePriceValid = false;
                }
                else
                {

                    propPriceInput.Text = "Saved Successfully";
                    homePriceValid = true;

                    hmln.PurchasePrice = homePrice;
                }

                //Validate input
                double homeDeposit = 0;


                if (!double.TryParse(bs.HomeDeposit, out homeDeposit))
                {

                    propDepositInput.Text = "Invalid Input";
                    homeDepositValid = false;
                }
                else
                {

                    propDepositInput.Text = "Saved Successfully";
                    homeDepositValid = true;

                    hmln.TotalDeposit = homeDeposit;
                }

                //Validate input
                double homeInterest = 0;


                if (!double.TryParse(bs.HomeInterest, out homeInterest))
                {

                    propInterestInput.Text = "Invalid Input";
                    homeInterestValid = false;
                }
                else
                {

                    propInterestInput.Text = "Saved Successfully";
                    homeInterestValid = true;

                    hmln.InterestRate = homeInterest;
                }

                //Validate input
                int homeMonthsToRepay = 0;

                ComboBoxItem cbi = (ComboBoxItem)propMonthsCB.SelectedItem;
                string val = cbi.Content.ToString();

                if (string.IsNullOrEmpty(val))
                {
                    propMonthsCB.Text = "Invalid Input";
                    homeMonthsToRepayValid = false;
                }
                else
                {

                    propMonthsCB.Text = "Saved Successfully";
                    homeMonthsToRepayValid = true;
                    homeMonthsToRepay = Convert.ToInt32(val);
                    hmln.RepayMonths = homeMonthsToRepay;

                }

                //Check that all fields have being filled, no null values
                if ((homePriceValid == true) && (homeDepositValid == true) && (homeInterestValid == true) && (homeMonthsToRepayValid == true))
                {

                    //Call Calc HomeLoan monthly payments method
                    hmln.CalcMonthlyBond();

                    //Populate dictionary
                    populateDict.dictExpenses.Add("Home Monthly Payment", hmln.MonthlyAmount);

                    //Check if monthly payments > a thid of gross salary
                    if (hmln.MonthlyAmount >= hmln.ThirdOfGrossSalary)
                    {

                        //Trigger Warning
                        loanRejectedBlock.Visibility = Visibility.Visible;

                    }

                    //Call the CalculateExpense method from the PopulateDictionary class, using the parameters passed to it
                             hmln.CalculateExpense(bs.GrossSalary, populateDict.sumDict(), bs.TaxAmount, hmln.MonthlyAmount);
    }
                

            }
        }

        //Button Clicked
        private void Rent_Click(object sender, RoutedEventArgs e)
        {

            //HotSwap Buttons
            RentalSelected = true;
            HomeSelected = false;

            buyPanel.Visibility = Visibility.Hidden;
            rentPanel.Visibility = Visibility.Visible;
            buyButton.Visibility = Visibility.Visible;
            rentButton.Visibility = Visibility.Hidden;

        }

        //Button Clicked
        private void Buy_Click(object sender, RoutedEventArgs e)
        {

            //HotSwap Buttons
            RentalSelected = false;
            HomeSelected = true;

            rentPanel.Visibility = Visibility.Hidden;
            buyPanel.Visibility = Visibility.Visible;
            rentButton.Visibility= Visibility.Visible;
            buyButton.Visibility= Visibility.Hidden;

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

