using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars_OOPS
{
    internal interface EnterPerson
    {
        int EntroprenurId { get; set; }
        string? BusinessName { get; set; }
        string? BusinessType { get; set; }

        double InvestmentAmount { get; set; }
        int YearsInBusiness { get; set; }

        void DisplayEntroprenurDetails();
        string GetEntroprenurInfo();
    }
}
