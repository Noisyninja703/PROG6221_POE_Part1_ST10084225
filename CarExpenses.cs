using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part_1
{
    abstract class CarExpenses
    {
        //**************************************************************      Declare availAmount      *****************************************************************************************
        public double availAmount;

        //**************************************************************      Calculate Car Expense      *****************************************************************************************

        //Create the abstract method CarCalcExpense
        public abstract void CarCalcExpense(double salary, double expenses, double taxAmount, double accommodation, double carExpense);

    }
}
