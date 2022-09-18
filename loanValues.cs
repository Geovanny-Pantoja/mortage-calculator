using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageLoanCalculator
{
    public class loanValues
    {
        public double HomeMarketValue { get; set; }
        public double HomePrice { get; set; }
        public double DownPaymnet { get; set; }
        public int TermOfLoan { get; set; }
        public double LoanInterestRate { get; set; }
        public double YearlyHOAFee { get; set; }
        public double BuyersMonthlyIncome { get; set; }
        public double LoanValue { get; set; }
        public double EquityValue { get; set; }
        public double MonthlyHoaCalculation { get; set; }
        public double InitialPropertyTax { get; set; }
        public double LoanInsurance { get; set; }
        public double HomeInsurance { get; set; }
        public double LoanMonthlyPayment { get; set; }
        public double LoanpmtPlusEscrow { get; set; }
        public double PaymentIncomeratio { get; set; }
    }
}
