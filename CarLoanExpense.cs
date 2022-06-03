using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part_1
{
    class CarLoanExpense : CarExpenses
    {
        private string modelAndMake;
        private double carPurchasePrice;
        private double carTotalDeposit;
        private double carInterestRate;
        private double carInsurancePremium;
        public double monthlyCost = 0;

        public string ModelAndMake { get => modelAndMake; set => modelAndMake = value; }
        public double CarPurchasePrice { get => carPurchasePrice; set => carPurchasePrice = value; }
        public double CarTotalDeposit { get => carTotalDeposit; set => carTotalDeposit = value; }
        public double CarInterestRate { get => carInterestRate; set => carInterestRate = value; }
        public double CarInsurancePremium { get => carInsurancePremium; set => carInsurancePremium = value; }


        public double CalcMonthlyPayment()
        {

            double cost = 0;

            double principleAmount = carPurchasePrice - carTotalDeposit;
            carInterestRate = carInterestRate / 100;

            cost = principleAmount * (1 + (carInterestRate * 5));

            monthlyCost = cost / 60;
            monthlyCost += carInsurancePremium;
            monthlyCost = Math.Round(monthlyCost, 2);

            return monthlyCost;

        }



        public override void CarCalcExpense(double salary, double expenses, double taxAmount, double accommodation, double carExpense)
        {

            availAmount = salary - (taxAmount + expenses + accommodation + carExpense);

        }

    }
}
