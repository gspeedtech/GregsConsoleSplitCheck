﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregsConsoleSplitCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Check FirstCheck = new Check();
            FirstCheck.CheckID = 1;
            FirstCheck.CheckName = "First Check";
            FirstCheck.CheckTaxPercentage = .0725;
            FirstCheck.CheckTipPercentage = .18;
            FirstCheck.AddCheckItem(0, 0, "Entree", 19.96, 3);
            FirstCheck.AddCheckItem(0, 0, "Drink", 9.90, 2);
            FirstCheck.AddCheckItem(0, 0, "Dessert", 5.95);
            FirstCheck.AddCheckItem(1, 0, "Entree", 19.96, 3);
            FirstCheck.AddCheckItem(1, 0, "Drink", 9.90, 2);
            FirstCheck.AddCheckItem(1, 0, "Dessert", 5.95);
            FirstCheck.AddPartyTaxItems(FirstCheck);
            FirstCheck.AddPartyTipItems(FirstCheck);
            FirstCheck.GetCheckTotals(FirstCheck);
        }
    }
}
