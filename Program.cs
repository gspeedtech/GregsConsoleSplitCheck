using System;
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
            FirstCheck.AddCheckItem(0, 1, "Entree", 19.96, 3);
            FirstCheck.AddCheckItem(0, 2, "Drink", 9.90, 2);
            FirstCheck.AddCheckItem(0, 3, "Dessert", 5.95);
            FirstCheck.AddCheckItem(1, 3, "Entree", 19.96, 3);
            FirstCheck.AddCheckItem(1, 2, "Drink", 9.90, 2);
            FirstCheck.AddCheckItem(1, 1, "Dessert", 5.95);
            FirstCheck.AddPartyTaxItems(FirstCheck);
            FirstCheck.AddPartyTipItems(FirstCheck);
            FirstCheck.AddDinerTaxItems(FirstCheck);
            FirstCheck.AddDinerTipItems(FirstCheck);
            FirstCheck.GetCheckTotals(FirstCheck);
        }
    }
}
