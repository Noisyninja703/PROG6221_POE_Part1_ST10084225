﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part_1
{
    class RentalExpense : Expenses
    {

        //**************************************************************      Rental Expense Calculate Expense      *****************************************************************************************

        //Override the CalculateExpense method for RentalExpense, too calc the surplus amount after expenses when renting
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

