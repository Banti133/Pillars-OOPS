using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars_OOPS
{
    internal class TechnoPerson: Person, EnterPerson
    {
        public TechnoPerson()
        {
            EntroprenurId=0;
            BusinessName = null;
            BusinessType = null;
            InvestmentAmount = 0.0;
            YearsInBusiness = 0;
        }
        public TechnoPerson(int id, string name, string email,
            int entroprenurId, string businessName, string businessType, double investmentAmount, int yearsInBusiness)
            : base(id, name, email)
        {
            EntroprenurId = entroprenurId;
            BusinessName = businessName;
            BusinessType = businessType;
            InvestmentAmount = investmentAmount;
            YearsInBusiness = yearsInBusiness;
        }

        // Properties for Entroprenur class
        public int EntroprenurId { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessType { get; set; }
        public double InvestmentAmount { get; set; }
        public int YearsInBusiness { get; set; }

        public void DisplayEntroprenurDetails()
        {
            Console.WriteLine($"Entrepreneur ID: {EntroprenurId}");
            Console.WriteLine($"Business Name: {BusinessName}");
            Console.WriteLine($"Business Type: {BusinessType}");
            Console.WriteLine($"Investment Amount: {InvestmentAmount:C}");
            Console.WriteLine($"Years in Business: {YearsInBusiness}");
            base.DisplayDetails(); // Call the base class method to display person details
        }

        public string GetEntroprenurInfo()
        {
            return $"Entrepreneur ID: {EntroprenurId}, Business Name: {BusinessName}, Business Type: {BusinessType}, " +
                   $"Investment Amount: ${InvestmentAmount}, Years in Business: {YearsInBusiness}, " +
                   base.GetPersonInfo(); // Call the base class method to get person info
        }
    }
}
