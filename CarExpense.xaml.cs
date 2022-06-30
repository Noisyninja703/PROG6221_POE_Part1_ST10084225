using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace PROG6221_POE_Draft2
{

    public partial class CarExpense : Page
    {
        //Instantiate onjects for binding and initialize variables
        BindAndStore bs = new BindAndStore();
        PopulateDictionary populateDict = new PopulateDictionary();
        HomeLoanExpense hmln = new HomeLoanExpense();
        RentalExpense rental = new RentalExpense();
        HomeExpensesPage homeExpenses = new HomeExpensesPage();
        CarLoanExpense car = new CarLoanExpense();

        static bool carCheck = false;
        bool carMakeValid = false;
        bool carPriceValid = false;
        bool carDepositValid = false;
        bool carInterestValid = false;
        bool carInsuranceValid = false;

        //Gets And Sets on public instance of static/private variable
        public bool CarCheck 
        { 
            get 
            {
                return carCheck; 
            }
            
            set
            {
                carCheck = value; 
            } 
        }

        public CarExpense()
        {
            //DataContext
            this.DataContext = bs;
            InitializeComponent();
        }

        //Button Clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Validate input
            if (CarCheck)
            {

                //Validate input
                string vehicleMake = "";
                vehicleMake = bs.VehicleMake;


                if (string.IsNullOrEmpty(vehicleMake))
                {

                    vehicleMakeInput.Text = "Invalid Input";
                    carMakeValid = false;
                }
                else
                {

                    vehicleMakeInput.Text = "Saved Successfully";
                    carMakeValid = true;

                    car.ModelAndMake = vehicleMake;
                }

                //Validate input
                double vehiclePrice = 0;


                if (!double.TryParse(bs.VehiclePrice, out vehiclePrice))
                {

                    vehiclePriceInput.Text = "Invalid Input";
                    carPriceValid = false;

                }
                else
                {

                    vehiclePriceInput.Text = "Saved Successfully";
                    carPriceValid = true;
                    car.CarPurchasePrice = vehiclePrice;
                }

                //Validate input
                double vehicleDeposit = 0;


                if (!double.TryParse(bs.VehicleDeposit, out vehicleDeposit))
                {

                    vehicleDepositInput.Text = "Invalid Input";
                    carDepositValid = false;

                }
                else
                {

                    vehicleDepositInput.Text = "Saved Successfully";
                    carDepositValid = true;
                    car.CarTotalDeposit = vehicleDeposit;

                }

                //Validate input
                double vehicleInterest = 0;


                if (!double.TryParse(bs.VehicleInterest, out vehicleInterest))
                {

                    vehicleInterestInput.Text = "Invalid Input";
                    carInterestValid = false;

                }
                else
                {

                    vehicleInterestInput.Text = "Saved Successfully";
                    carInterestValid = true;
                    car.CarInterestRate = vehicleInterest;
                }

                //Validate input
                double vehicleInsurance = 0;


                if (!double.TryParse(bs.VehicleInsurance, out vehicleInsurance))
                {

                    vehicleInsuranceInput.Text = "Invalid Input";
                    carInsuranceValid = false;

                }
                else
                {

                    vehicleInsuranceInput.Text = "Saved Successfully";
                    carInsuranceValid = true;
                    car.CarInsurancePremium = vehicleInsurance;
                }

            }

            else { CarCheck = false; }

            //Check that all fields have being filled, no null values
            if ((carMakeValid == true) && (carPriceValid == true) && (carDepositValid == true) && (carInterestValid == true) && (carInsuranceValid == true))
            {

                //Call car payments calc method
                car.CalcMonthlyPayment();
                

            }

        }

        //Button Clicked
        private void NoCar_Click(object sender, RoutedEventArgs e)
        {

            //HotSwap Buttons
            CarCheck = false;
            carSelected.Text = "Selected Not To Buy A Car";
            buyCarButton.Visibility = Visibility.Visible;
            noCarButton.Visibility = Visibility.Hidden;
            NoCarStack.Visibility = Visibility.Visible;
            CarDudeStack.Visibility = Visibility.Hidden;
            BuyCarStack.Visibility = Visibility.Hidden;

        }

        //Button Clicked
        private void BuyCar_Click(object sender, RoutedEventArgs e)
        {

            //HotSwap Buttons
            CarCheck = true;
            carSelected.Text = "Selected To Buy A Car";
            buyCarButton.Visibility = Visibility.Hidden;
            noCarButton.Visibility = Visibility.Visible;
            BuyCarStack.Visibility = Visibility.Visible;
            CarDudeStack.Visibility = Visibility.Visible;
            NoCarStack.Visibility = Visibility.Hidden;

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
