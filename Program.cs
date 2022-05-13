using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG6221_POE_Part_1
{
    public class Program
    {

        //**************************************************************      Variables And Objects      *****************************************************************************************

        PopulateArrayLists populateArray = new PopulateArrayLists();
        HomeLoanExpense hmln = new HomeLoanExpense();
        RentalExpense rental = new RentalExpense();

        public double grossSalary;
        public double thirdOfGrossSalary;
        public double taxAmount;
        public double rentalAmount;
        public double totalExpense;

        //**************************************************************      Main      *****************************************************************************************

        static void Main(string[] args)
        {

            //Create an object to call the display menthod
            Program main = new Program();

            //Call the SplashScreen method
            main.SplashScreen();

            //Call the display method
            main.DisplayMenu();

            //Keep the console open
            Console.ReadLine();
        }

        //**************************************************************      Display Menu      *****************************************************************************************

        //Initialize the display method
        public void DisplayMenu()
        {

            //Print the menu

            Console.Write("*****************************************************************" + "\n" +
                              "Please Choose One Of The Following Options: \n" +
                              "1.) Start Your Budget Plan. \n" +
                              "2.) Exit Application." + "\n" +
                              "*****************************************************************\n\n" +
                              "Your Selection >> ");


            //Create a boolean to use for selection validation
            bool bInvalid = true;

            //Get input from the user
            string menuOption = Console.ReadLine();

            //A while loop used to check for and correct invalid selections
            while (bInvalid)
            {

                //If, the selection is empty or not one of the displayed options, notify the user and get a new selection
                if (string.IsNullOrEmpty(menuOption) || !(menuOption.Equals("1") || menuOption.Equals("2")))
                {

                    bInvalid = true;

                    //Error message
                    ErrorMessgae();

                    Console.Write("*****************************************************************" + "\n" +
                              "Please Choose One Of The Following Options: \n" +
                              "1.) Start Your Budget Plan. \n" +
                              "2.) Exit Application." + "\n" +
                              "*****************************************************************\n\n" +
                              "Your Selection >> ");

                    menuOption = Console.ReadLine();

                }

                //Else, the selection was valid
                else
                {

                    bInvalid = false;

                }

                //If, the selection was valid, select the chosen option using a switch
                if (!bInvalid)
                {

                    //Switch based on selection
                    switch (menuOption)
                    {

                        //Call the budget planner method
                        case "1": BudgetPlanner(); break;

                        //Call the exit method
                        case "2": ExitApplication(); break;

                    }
                }
            }
        }

        //**************************************************************      Budget Planner      *****************************************************************************************

        //Create the budget planner method
        public void BudgetPlanner()
        {

            //Print the instructions and prompt the user for input
            Console.Write("\n*****************************************************************" + "\n" +
                          "Let's Start With Your Budget Plan :D \n" +
                          "*****************************************************************" + "\n" +
                          "\n Please Enter Your Gross Salary Before Deductions >> R");

            //Gross salary

            //Initialize the salary variable
            grossSalary = 0.00;



            //While, getting input from the user, validate that the given value is a double, otherwise get a new input
            while (!double.TryParse(Console.ReadLine(), out grossSalary))
            {

                //Error message
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For Salary \n");
                Console.Write("Enter Salary Amount Again >> R");

            }

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Salary Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Get the value of one third of the user's gross salary
            hmln.ThirdOfGrossSalary = grossSalary / 3;

            //Estimated Monthly Taxes
            Console.Write("\n*****************************************************************\n\n" +
                          "Enter your estimated monthly tax amount >> R");

            //Initialize the taxAmount variable
            taxAmount = 0.00;


            //While, getting input from the user, validate that the given value is a double, otherwise get a new input
            while (!double.TryParse(Console.ReadLine(), out taxAmount))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For Monthly Tax Amount\n.");
                Console.WriteLine("Enter Your Estimated Monthly Tax Amount Again >> R");

            }

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Tax Amount Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


            //Groceries
            Console.Write("\n*****************************************************************\n\n" +
                              "Enter Your Estimated Expenses For Groceries >> R");
            double groceriesAmount = 0.00;

            //While, getting input from the user, validate that the given value is a double, otherwise get a new input
            while (!Double.TryParse(Console.ReadLine(), out groceriesAmount))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For Your Groceries Expenses Amount.\n");
                Console.Write("Enter Your Estimated Expenses For Groceries Again >> R");

            }

            //Populate the arraylist
            populateArray.arrayExpenseName.Add("Groceries");
            populateArray.arrayExpenseCost.Add(groceriesAmount);

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Expenses For Groceries Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Water and lights
            Console.Write("\n*****************************************************************\n\n" +
                              "Enter Your Estimated Expenses For Water And Lights >> R");

            //Initialize the waterAndLights variable
            double waterAndLights = 0;

            //While, getting input from the user, validate that the given value is a double, otherwise get a new input
            while (!double.TryParse(Console.ReadLine(), out waterAndLights))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For Your Water And Lights Expenses.\n");
                Console.Write("Enter Your Estimated Expenses On Water And Lights Again >> R");

            }

            //Populate the arraylist
            populateArray.arrayExpenseName.Add("Water And Lights");
            populateArray.arrayExpenseCost.Add(waterAndLights);

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Expenses For Water And Lights Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


            Console.Write("\n*****************************************************************\n\n" +
                              "Enter Your Estimated Expenses For Travel Costs(Including Fuel) >> R");

            //Initialize the travelCost variable
            double travelCost = 0;

            //While, getting input from the user, validate that the given value is a double, otherwise get a new input
            while (!double.TryParse(Console.ReadLine(), out travelCost))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For Travel Costs.\n");
                Console.Write("Enter Your Estimated Expenses For Travel Costs(Including Fuel) Again >> R");

            }

            //Populate the arraylist
            populateArray.arrayExpenseName.Add("Travel Costs");
            populateArray.arrayExpenseCost.Add(travelCost);

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Expenses For Your Travel Costs Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("\n*****************************************************************\n\n" +
                          "Enter Your Estimated Expenses For Cellphone And Telephone Billing >> R");

            //Initialize the phoneBill variable
            double phoneBill = 0;

            //While, getting input from the user, validate that the given value is a double, otherwise get a new input
            while (!double.TryParse(Console.ReadLine(), out phoneBill))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please enter a valid numerical value for phone bills\n");
                Console.Write("Enter your estimated expenditure on cellphone and telephone billing again >> R");

            }

            //Populate the arraylist
            populateArray.arrayExpenseName.Add("Phone Bills");
            populateArray.arrayExpenseCost.Add(phoneBill);

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Expenses For Phone Bills Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Call the OtherExpensesOrAccomodation Method
            OtherExpensesAndAccommodation();
        }

        //**************************************************************      Other Expenses And Accommodation      *****************************************************************************************

        //Create the OtherExpensesOrAccomodation Method 
        public void OtherExpensesAndAccommodation()
        {

            //Prompt the user to add other expenses or continue
            Console.Write("\n*****************************************************************\n\n" +
                              "Do You Have Any Other Expenses?" + "\n" + "Press 1 To Add An Expense" + "\n" +
                              "Press 2 To Continue With Your Budget Plan.\n" +
                              "Your Selection >> ");

            //Create a boolean to use for selection validation
            bool bInvalid = true;

            //Create a string for selection 
            string menuOption = Console.ReadLine();

            //While, an invalid selection has being made, prompt the user for a new selection
            while (bInvalid)
            {

                //If, the selection is empty or isn't part of the given options, prompt the user for a new selection
                if (string.IsNullOrEmpty(menuOption) || !(menuOption.Equals("1") || menuOption.Equals("2")))
                {

                    bInvalid = true;

                    //Error message -- Invalid input
                    ErrorMessgae();

                    Console.Write("Do You Have Any Other Expenses?" + "\n" + "Press 1 To Add An Expense" + "\n" +
                                  "Press 2 To Continue With Your Budget Plan.\n" +
                                  "Your Selection >> ");

                    menuOption = Console.ReadLine();

                }

                //Else, the selection is valid
                else
                {

                    bInvalid = false;

                }

                //If, the selection is valid, call the related method
                if (!bInvalid)
                {

                    //A switch using the menuOption Variable
                    switch (menuOption)
                    {

                        //Call the OtherExpenses method
                        case "1": OtherExpenses(); break;

                        //Call the Accomodation method
                        case "2": Accommodation(); break;
                    }
                }
            }
        }

        //**************************************************************      Other Expenses      *****************************************************************************************

        //Create the OtherExpenses method
        public void OtherExpenses()
        {

            //Prompt the user for the expense name
            Console.Write("\n*****************************************************************\n\n" +
                              "What Is The Name Of Your Expense >> ");

            //Get the name from the user
            string addExpense = Console.ReadLine();

            //Create a boolean for input validation
            bool bInvalid = true;

            //While bInvalid is true, check that the given input is valid
            while (bInvalid)
            {

                //If, the input is invalid, get new input
                if (string.IsNullOrEmpty(addExpense))
                {

                    //Error message -- Invalid input
                    ErrorMessgae();

                    bInvalid = true;

                    Console.Write("What Is The Name Of Your Expense >> ");

                    addExpense = Console.ReadLine();
                }

                //Else the selection is valid
                else
                {
                    bInvalid = false;
                }

            }

            //If, the input was valid, populate the arraylist and get the expense value from the user
            if (!bInvalid)
            {

                //Populate the arraylist
                populateArray.arrayExpenseName.Add(addExpense);

                //Prompt the user for the cost of their expense
                Console.Write("Enter Your Estimated Expense For " + addExpense + " >> R");

                //Initialize the addExpenseAmount variable
                double addExpenseAmount = 0;

                //While the given value is not a valid double, get a new value from the user
                while (!double.TryParse(Console.ReadLine(), out addExpenseAmount))
                {

                    //Error message -- Invalid input
                    ErrorMessgae();

                    Console.WriteLine("Please Enter A Valid Numerical Value For " + addExpense + "\n");

                    Console.Write("Enter Your Estimated Expense For " + addExpense + " Again >> R");

                }

                //Populate the arraylist
                populateArray.arrayExpenseCost.Add(addExpenseAmount);

                //Success notification
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Expense For " + addExpense + " Saved Successfully!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;


            }
            OtherExpensesAndAccommodation();
        }

        //**************************************************************      Accommodation      *****************************************************************************************

        public void Accommodation()
        {

            //Prompt the user for selection
            Console.Write("\n*****************************************************************\n\n" +
                              "Please Select Your Accommodation Type. Enter The Appropirate Option's Number. \n" +
                              "1.) Rent Accommodation. \n" +
                              "2.) Buy A Property. \n" +
                              "Your Selection >> ");

            //Create a boolean for selection validation
            bool bInvalid = true;

            //Create a string for selection
            string menuOption = Console.ReadLine();

            //While, bInvalid is true, validate that the selection is valid and call the appropriate methods
            while (bInvalid)
            {

                //If, the selection is empty or not one of the given options, get a new selection
                if (string.IsNullOrEmpty(menuOption) || !(menuOption.Equals("1") || menuOption.Equals("2")))
                {
                    bInvalid = true;

                    //Error message -- Invalid input
                    ErrorMessgae();

                    Console.Write("Invalid menu item. \n" +
                                  "Please Select Your Accommodation Type. Enter The Appropirate Option's Number. \n" +
                                  "1.) Rent Accommodation. \n" +
                                  "2.) Buy A Property.\n " +
                                  "Your Selection >> ");

                    menuOption = Console.ReadLine();
                }

                //Else the selection is valid
                else
                {

                    bInvalid = false;

                }

                //If, the selection is valid, Use a switch too call the appropriate method
                if (!bInvalid)
                {

                    //A switch using the menuOption variable
                    switch (menuOption)
                    {

                        //Call the RentAccommodation method
                        case "1": RentAccommodation(); break;

                        //Call the BuyProperty method
                        case "2": BuyProperty(); break;

                    }

                }
            }
        }

        //**************************************************************      Buy Property      *****************************************************************************************

        //Create the BuyProperty method
        public void BuyProperty()
        {
            Console.Write("\n*****************************************************************\n\n" +
                          "Please Enter The Purchase Price Of The Property >> R");

            //Initialize the housePurchasePrice variable
            double housePurchasePrice = 0;

            //While, the given input is not a valid double, get new input from the user
            while (!double.TryParse(Console.ReadLine(), out housePurchasePrice))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For The Purchase Price\n");
                Console.Write("Please Enter The Purchase Price Of The Property Again >> R");

            }

            //Assign the value to the PurchasePrice variable in the HomeLoanExpense class 
            hmln.PurchasePrice = housePurchasePrice;

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Purchase Price Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


            //Prompt the user for the total deposit
            Console.Write("\n*****************************************************************\n\n" +
                          "Please Enter The Total Deposit >> R");
            double TotalDeposit = 0;

            //While, the given input is not a valid double, get new input from the user
            while (!double.TryParse(Console.ReadLine(), out TotalDeposit))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For The Total Deposit\n");
                Console.Write("Please Enter The Total Deposit Again >> R");

            }

            //Assign the value to the TotalDeposit variable in the HomeLoanExpense class 
            hmln.TotalDeposit = TotalDeposit;

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Total Deposit Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


            //Prompt the user for the annual interest rate
            Console.Write("\n*****************************************************************\n\n" +
                          "Please Enter Interest Rate In Percentage Format(%) >> ");

            //Initialize the InterestRate Variable
            double InterestRate = 0;

            //While the input is not a valid double, get new input
            while (!double.TryParse(Console.ReadLine(), out InterestRate) || InterestRate < 0)
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For The Interest Rate\n");
                Console.Write("Please Enter Interest Rate In Percentage Format(%) Again >> ");

            }

            //Assign the value to the InterestRate variable in the HomeLoanExpense class 
            hmln.InterestRate = InterestRate;

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Interest Rate Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Prompt the user for the number of months to repay
            Console.Write("\n*****************************************************************\n\n" +
                          "How Many Months Do You Have To Repay The Home Loan?" + "\n" +
                          "1.) 240 Months " + "\n " +
                          "2.) 360 Months\n" +
                          "Your Selection >> ");

            //Initialize the RepayMonths variable
            int RepayMonths = 0;

            //Create a boolean for selection validation
            bool bInvalid = true;

            //Create a string for menu selection 
            string menuOption = Console.ReadLine();

            //While bInvalid is true, validate the selection then execute the switch
            while (bInvalid)
            {

                //If the input is empty or not one of the given options, get new input
                if (string.IsNullOrEmpty(menuOption) || !(menuOption.Equals("1") || menuOption.Equals("2")))
                {

                    bInvalid = true;

                    //Error message -- Invalid input
                    ErrorMessgae();

                    Console.Write("How Many Months Do You Have To Repay The Home Loan?" + "\n" +
                                  "1.) 240 Months " + "\n " +
                                  "2.) 360 Months\n" +
                                  "Your Selection >> ");

                    menuOption = Console.ReadLine();

                }

                //Else, selection is valid
                else
                {
                    bInvalid = false;

                }

                //If, the selection is valid execute the switch
                if (!bInvalid)
                {

                    //Switch
                    switch (menuOption)
                    {

                        //Repay months = 240
                        case "1":
                            RepayMonths = 240;

                            //Assign the value to the RepayMonths variable in the HomeLoanExpense class 
                            hmln.RepayMonths = RepayMonths;

                            //Success notification
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Number Of Months To Repay The Loan Saved Successfully!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                            //Call the CalcMonthlyBond method from the HomeLoanExpense class
                            hmln.CalcMonthlyBond();

                            //Populate the arraylist
                            populateArray.arrayExpenseName.Add("Home Loan Monthly Repayments");
                            populateArray.arrayExpenseCost.Add(hmln.monthlyAmount);

                            //Call the CalculateExpense method from the PopulateArrayLists class, using the parameters passed to it
                            hmln.CalculateExpense(grossSalary, populateArray.sumArray(), taxAmount, hmln.monthlyAmount);
                            BudgetReport();
                            break;

                        //Repay months = 360
                        case "2":
                            RepayMonths = 360;

                            //Assign the value to the RepayMonths variable in the HomeLoanExpense class 
                            hmln.RepayMonths = RepayMonths;

                            //Success notification
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Number Of Months To Repay The Loan Saved Successfully!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;

                            //Call the CalcMonthlyBond method from the HomeLoanExpense class
                            hmln.CalcMonthlyBond();

                            //Populate the arraylist
                            populateArray.arrayExpenseName.Add("Home Loan Monthly Repayments");
                            populateArray.arrayExpenseCost.Add(hmln.monthlyAmount);

                            //Call the CalculateExpense method from the PopulateArrayLists class, using the parameters passed to it
                            hmln.CalculateExpense(grossSalary, populateArray.sumArray(), taxAmount, hmln.monthlyAmount);
                            BudgetReport();
                            break;

                    }
                }
            }
        }

        //**************************************************************      Rent Accommodation      *****************************************************************************************

        //Create the RentAccommodation method
        public void RentAccommodation()
        {

            //Prompt the user for the monthly rent cost
            Console.Write("\n*****************************************************************\n\n" +
                          "Please Enter The Monthly Rent Amount >> R");

            //Initialize the rentalAmount variable
            double rentalAmount = 0;

            //While, the given input is not a valid double, get new input from the user
            while (!double.TryParse(Console.ReadLine(), out rentalAmount))
            {

                //Error message -- Invalid input
                ErrorMessgae();

                Console.WriteLine("Please Enter A Valid Numerical Value For The Rent\n");
                Console.Write("Please Enter The Rent Amount >> R");

            }

            //Success notification
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Rent Saved Successfully!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Call the CalculateExpense method from the RentalExpense class, using the passed parameters
            rental.CalculateExpense(grossSalary, populateArray.sumArray(), taxAmount, rentalAmount);

            //Populate the arraylist
            populateArray.arrayExpenseName.Add("Accommodation Monthly Rental Fee");
            populateArray.arrayExpenseCost.Add(rentalAmount);

            //Call the BudgetReport method
            BudgetReport();
        }

        //**************************************************************      Budget Report      *****************************************************************************************

        //Create the budget report method
        public void BudgetReport()
        {

            //Print the gross salary before and after taxes
            Console.WriteLine("\n*****************************************************************\n\n");
            Console.WriteLine("Your Budget Report Is As Followes: " + "\n");
            Console.WriteLine("Your Gross Salary Is R" + grossSalary + "\n");
            Console.WriteLine("\nYour Estimated Taxes Cost R" + taxAmount + "\n");
            Console.WriteLine("\nYour Salary After Taxes Is R" + (grossSalary - taxAmount) + "\n");
            Console.WriteLine("\n" +
                "*****************************************************************\n\n");
            Console.WriteLine("\nYour Monthly Expenses Are As Followes: \n");

            //For loop to print the expenses and their names from the arraylists
            for (int i = 0; i < populateArray.arrayExpenseName.Count; i++)
            {

                Console.WriteLine(populateArray.arrayExpenseName[i] + ": R" + populateArray.arrayExpenseCost[i] + "\n\n");


            }

            Console.WriteLine("*****************************************************************\n");
            Console.WriteLine("Your Total Expenses Come Too: R" + Math.Round(populateArray.sumArray()), 2); //Round off to 2 decimal places
            Console.WriteLine("\n" + "*****************************************************************\n\n");

            //Create an int to use as a keyword for a switch
            int menuOption = 0;

            //Check how much of the user's gross salary is left over after expenses relative to percentage
            if (hmln.availAmount >= grossSalary * 0.6 && hmln.availAmount <= grossSalary) { menuOption = 1; }
            if (hmln.availAmount >= grossSalary * 0.33 && hmln.availAmount <= grossSalary * 0.6) { menuOption = 2; }
            if (hmln.availAmount > 0 && hmln.availAmount <= grossSalary * 0.33) { menuOption = 3; }
            if (hmln.availAmount < 0) { menuOption = 4; }


            if (rental.availAmount >= grossSalary * 0.6 && rental.availAmount <= grossSalary) { menuOption = 1; }
            if (rental.availAmount >= grossSalary * 0.33 && rental.availAmount <= grossSalary * 0.6) { menuOption = 2; }
            if (rental.availAmount > 0 && rental.availAmount <= grossSalary * 0.33) { menuOption = 3; }
            if (rental.availAmount < 0) { menuOption = 4; }

            //If, rental was not chosen, apply calc using HomeLoanExpense, Else, Use rentalExpense
            //Else if, Displays the amount available after calculations in different colours based of what percentage of the gross salary is left
            // Green - More than 60% // Yellow - More than 33% // Dark Yellow - Less than 33% // Dark Red - Less than 0%
            if (rental.availAmount == 0)
            {

                switch (menuOption)
                {
                    case 1:

                        //Surplus amount > 60% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: R" + hmln.availAmount + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;



                    case 2:

                        //Surplus amount > 33% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: R" + hmln.availAmount + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;


                    case 3:

                        //Surplus amount < 33% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: R" + hmln.availAmount + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;


                    case 4:

                        //Surplus amount < 0% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: -R" + (hmln.availAmount * -1) + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;
                }
            }

            else
            {
                switch (menuOption)
                {
                    case 1:

                        //Surplus amount > 60% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: R" + rental.availAmount + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;

                    case 2:

                        //Surplus amount > 33% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: R" + rental.availAmount + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;

                    case 3:

                        //Surplus amount < 33% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: R" + rental.availAmount + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;

                    case 4:

                        //Surplus amount < 0% of gross salary
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("*****************************************************************\n" +
                                      "Your Available Monthly Balance Is: -R" + (rental.availAmount * -1) + "                         " +
                                      "\n*****************************************************************\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;


                }
            }
        }


        //**************************************************************      Error Message      *****************************************************************************************

        //Create the ErrorMessage Method
        public void ErrorMessgae()
        {

            //Print error message for invalid input
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n*****************************************************************" + "\n" +
                              "Invalid Input Detected                                           \n" +
                              "*****************************************************************" + "\n");
            Console.BackgroundColor = ConsoleColor.Black;

            return;

        }

        //**************************************************************      Splash Screen      *****************************************************************************************

        //Create the SplashScreen method
        public void SplashScreen()
        {

            //Print Text
            Console.WriteLine("Please Be Patient While The Budget Planner App Loads In\n\n");

            //Print Loading
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("██╗░░░░░░█████╗░░█████╗░██████╗░██╗███╗░░██╗░██████╗░");
            Console.WriteLine("██║░░░░░██╔══██╗██╔══██╗██╔══██╗██║████╗░██║██╔════╝░");
            Console.WriteLine("██║░░░░░██║░░██║███████║██║░░██║██║██╔██╗██║██║░░██╗░");
            Console.WriteLine("██║░░░░░██║░░██║██╔══██║██║░░██║██║██║╚████║██║░░╚██╗");
            Console.WriteLine("███████╗╚█████╔╝██║░░██║██████╔╝██║██║░╚███║╚██████╔╝");
            Console.WriteLine("╚══════╝░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░\n\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Put the thread to sleep and simulate loading
            for (int i = 0; i < 27; i++)
            {

                //Progress Bar
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("▒▒");
                Thread.Sleep(100);

            }

            //Reset the console colour scheme
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Clear the console
            Console.Clear();

        }

        //**************************************************************      Exit Application      *****************************************************************************************

        //Create the ExitApplication method
        public void ExitApplication()
        {

            Console.Write("\n*****************************************************************" + "\n" +
                          "Are You Sure That You Want To Exit The Application?" + "\n" +
                          "Press 1 To Exit The Application " + "\n " +
                          "Press 2 To Return To The Main Menu.\n" +
                          "Your Selection >> ");

            //Create a boolean for selection validation
            bool bInvalid = true;

            //Create a string for menu selection 
            string menuOption = Console.ReadLine();

            //While bInvalid is true, validate the selection then execute the switch
            while (bInvalid)
            {

                //If the input is empty or not one of the given options, get new input
                if (string.IsNullOrEmpty(menuOption) || !(menuOption.Equals("1") || menuOption.Equals("2")))
                {

                    bInvalid = true;

                    //Error message -- Invalid input
                    ErrorMessgae();

                    Console.Write("\n*****************************************************************" + "\n" +
                          "Are You Sure That You Want To Exit The Application?" + "\n" +
                          "Press 1 To Exit The Application " + "\n " +
                          "Press 2 To Return To The Main Menu.\n" +
                          "Your Selection >> ");

                    menuOption = Console.ReadLine();
                }

                //Else, selection is valid
                else
                {
                    bInvalid = false;

                }

                //If, the selection is valid execute the switch
                if (!bInvalid)
                {

                    //Switch
                    switch (menuOption)
                    {

                        //Exit the application
                        case "1": System.Environment.Exit(0); ; break;

                        //Go back to the main menu
                        case "2": DisplayMenu(); break;
                    }
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