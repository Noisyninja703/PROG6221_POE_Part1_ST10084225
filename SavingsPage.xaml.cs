using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG6221_POE_Draft2
{
    /// <summary>
    /// Interaction logic for SavingsPage.xaml
    /// </summary>
    public partial class SavingsPage : Page
    {

        //Instantiate onjects for binding and initialize variables
        BindAndStore bs = new BindAndStore();

        bool savingReasonValid = false;
        bool savingAmountValid = false;
        bool savingInterestValid = false;
        bool savingYearsValid = false;

        public SavingsPage()
        {

            //DataContext
            this.DataContext = bs;
            InitializeComponent();

        }

        //Button Clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Validate input
            string reason = "";
            reason = bs.SavingReason;


            if (string.IsNullOrEmpty(reason))
            {

                savingReasonInput.Text = "Invalid Input";
                savingReasonValid = false;
            }
            else
            {

                savingReasonInput.Text = "Saved Successfully";
                savingReasonValid = true;

                bs.SavingReason = reason;
                savingReasonDisplay.Text = reason;
            }

            //Validate input
            double savingAmount = 0;
            string savingAmountCheck = bs.SavingAmount.ToString();

            if (!double.TryParse(savingAmountCheck, out savingAmount))
            {

                savingAmountInput.Text = "Invalid Input";
                savingAmountValid = false;

            }
            else
            {

                savingAmountInput.Text = "Saved Successfully";
                savingAmountValid = true;
                bs.SavingAmount = savingAmount;
            }

            //Validate input
            double savingInterest = 0;
            string savingInterestCheck = bs.SavingInterest.ToString();

            if (!double.TryParse(savingInterestCheck, out savingInterest))
            {

                savingInterestInput.Text = "Invalid Input";
                savingInterestValid = false;

            }
            else
            {

                savingInterestInput.Text = "Saved Successfully";
                savingInterestValid = true;
                bs.SavingInterest = savingInterest;
            }

            //Validate input
            int savingYears = 0;
            string savingYearsCheck = bs.SavingYears.ToString();

            if (!int.TryParse(savingYearsCheck, out savingYears))
            {

                savingYearsInput.Text = "Invalid Input";
                savingYearsValid = false;

            }
            else
            {

                savingYearsInput.Text = "Saved Successfully";
                savingYearsValid = true;
                bs.SavingYears = savingYears;
            }

            //Check that all fields have being filled, no null values
            if ((savingAmountValid == true) && (savingReasonValid == true) && (savingInterestValid == true) && (savingYearsValid == true))
            {

                //Assuming the users savings account implements simple interest
                //formula used: A=P(1+in) --> simple interest

                //Calc monthly savings
                double accumAmount = bs.SavingAmount * (1 + (bs.SavingInterest / 100 * bs.SavingYears));

                double monthlySavings = accumAmount / (bs.SavingYears * 12);

                double roundedMonthlySavings = Math.Round(monthlySavings, 2);

                //Display savings amount needed
                savingAmountDisplay.Text = roundedMonthlySavings.ToString();

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
