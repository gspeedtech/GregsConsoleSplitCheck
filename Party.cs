﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregsConsoleSplitCheck
{
    public class Party
    {
        public Party()
        {
            partyTaxItems = new List<TaxItem>();
            partyTipItems = new List<TipItem>();
        }
        public List<TaxItem> AddPartyTaxItems(Check Check)
        {
            foreach (var Id in Check.items.Select(x => x.PartyId).Distinct())
            {
                double itemTotal = 0;
                TaxItem taxItem = new TaxItem();
                foreach (var row in Check.items.Where(y => y.PartyId == Id))
                {
                    itemTotal += row.Price;
                }
                taxItem.PartyId = Id;
                taxItem.DinerId = 0;
                taxItem.ItemTotal = itemTotal;
                taxItem.TaxAmount = Math.Round((itemTotal * Check.CheckTaxPercentage), 2);
                taxItem.TaxPercent = Check.CheckTaxPercentage;
                taxItem.Diviser = 1;
                partyTaxItems.Add(taxItem);
            }
            return partyTaxItems;
        }

        public List<TipItem> AddPartyTipItems(Check Check)
        {
            foreach (var Id in Check.items.Select(x => x.PartyId).Distinct())
            {
                double itemTotal = 0;
                TipItem tipItem = new TipItem();
                foreach (var row in Check.items.Where(y => y.PartyId == Id))
                {
                    itemTotal += row.Price;
                }
                tipItem.PartyId = Id;
                tipItem.DinerId = 0;
                tipItem.ItemTotal = itemTotal;
                tipItem.TipAmount = Math.Round((itemTotal * Check.CheckTipPercentage), 2);
                tipItem.TipPercent = Check.CheckTipPercentage;
                tipItem.Diviser = 1;
                partyTipItems.Add(tipItem);
            }

            return partyTipItems;
        }
        public List<TaxItem> partyTaxItems;
        public List<TipItem> partyTipItems;
    }
}
