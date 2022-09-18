using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MortgageLoanCalculator
{
    public class Loan : loanValues
    {
     // setting user input values
        #region Set the Home Maarket Value
        public void SetHmv()
        {
            HomeMarketValue = 0;
            SETVALUE:
            while (HomeMarketValue <= 0)
            {
                WriteLine("Please enter the price of the Home Market Value:");
                try
                {
                    HomeMarketValue = Convert.ToDouble(ReadLine());
                    if (HomeMarketValue <= 0)
                    {
                        throw new ArithmeticException("Amount should be more than $0.00. Please try again");

                    }

                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }
            string answer = " ";

            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                WriteLine("Your input was {0:C}. Is this correct? if correct, please enter Yes. If not please enter No", HomeMarketValue);
                answer = ReadLine().ToUpper().Trim();
                
                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified that the amount is correct.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        HomeMarketValue = 0.00;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto SETVALUE;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }

            WriteLine("Home Market Value was set for: {0:C}", HomeMarketValue);



        }
        #endregion

        #region Get Home Market value String
        public string[] GetHMV()
        {
            string[] homeMarketValue = {"Home Market value is: " + "\t\t\t" + HomeMarketValue.ToString(("C")), " "};
            return homeMarketValue;
        }
        #endregion

        #region Set Home Price 
        public void SetHomePrice()
        {
            HomePrice = 0;
            setvalue:
            while (HomePrice <= 0)
            {
                WriteLine("Please enter the dollar amount of the loan requested:");
                try
                {
                    HomePrice = Convert.ToDouble(ReadLine());
                    if (HomePrice <= 0)
                    {
                        throw new ArithmeticException("Amount should be more than 0.00. Please try again");

                    }

                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }
            string answer = " ";
            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                WriteLine("Your input was {0:C}. Is this correct? if correct, please enter Yes. If not please enter No", HomePrice);
                answer = ReadLine().ToUpper().Trim();

                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified that the ammount is correct.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        HomePrice = 0.00;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto setvalue;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }

            WriteLine("Loan amount requested was set for: {0:C}", HomePrice);

        }

        #endregion

        #region Get Home Price
        public string[] GetHomePrice()
        {
            string[] homePrice = { "Home price (Loan requested) is: " + "\t" + HomePrice.ToString("C"), " " };
            return homePrice;
        }

        #endregion

        #region set DownPayment 
        public void SetDownPayment()
        {
            setvalue:
            DownPaymnet = -1;
            
            while (DownPaymnet < 0)
            {
                WriteLine("Please enter the dollar amount of the DownPayment:");
                try
                {
                    DownPaymnet = Convert.ToDouble(ReadLine());
                    if (DownPaymnet < 0)
                    {
                        throw new ArithmeticException("Amount should be more than 0.00. Please try again");

                    }
                    else if (DownPaymnet >= HomePrice)
                    {
                        
                        WriteLine("The amount of {0:C} is more or equal than the loan requested. Please verify the amount and try again.", DownPaymnet);
                        goto setvalue;
                    }

                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }

            string answer = " ";
            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                WriteLine("Your input was {0:C}. Is this correct? if correct, please enter Yes. If not please enter No", DownPaymnet);
                answer = ReadLine().ToUpper().Trim();

                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified that the ammount is correct.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        DownPaymnet = 0.00;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto setvalue;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }

            WriteLine("Loan amount requested was set for: {0:C}", DownPaymnet);
        }

        #endregion

        #region Get Down Payment

        public string[] GetDownPayment()
        {
            string[] downPayment = { "Down Payment is: " + "\t\t\t\t" + DownPaymnet.ToString("C"), " " };
            return downPayment;
        }

        #endregion

        #region Set Term of Loan 
        public void SetTerm()
        {
            TermOfLoan = 0;
            setvalue:
            while (TermOfLoan != 15 && TermOfLoan != 30)
            {
                WriteLine("What is the term of the loan in years? Please enter 15 or 30");
                try
                {
                    TermOfLoan = Convert.ToInt32(ReadLine());
                    switch (TermOfLoan)
                    {
                        case 15:
                             break;
                        case 30:
                             break;
                        default:
                           throw new ArithmeticException("Wrong number of years enter. Please try again");
                            
                    }
                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }
            string answer = " ";
            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                WriteLine("Your input was {0} years. Is this correct? if correct, please enter Yes. If not please enter No", TermOfLoan);
                answer = ReadLine().ToUpper().Trim();

                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified the loan term.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        TermOfLoan =0;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto setvalue;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }

            WriteLine($"The loan term is set for {TermOfLoan} years.");


        }

        #endregion

        #region get Loan Term

        public string[] GetLoanTerm()
        {
            string[] terms = {"Loan term is: " + "\t\t\t\t" + TermOfLoan.ToString() + " Years", " "};
            return terms;
        }





        #endregion

        #region set loan interest
        public void SetLoanInterestRate()
        {
            LoanInterestRate = 0;
            setvalue:
            while (LoanInterestRate <= 0)
            {
                WriteLine("Please enter the Loan interest rate ex 1.25 or 5.75:");
                try
                {
                    LoanInterestRate = Convert.ToDouble(ReadLine());
                    LoanInterestRate /= 100;
                    if (LoanInterestRate <= 0)
                    {
                        throw new ArithmeticException("interest rate should be more than 0.00%. Please try again");

                    }

                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }

            string answer = " ";
            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                WriteLine("Your input was {0:P}. Is this correct? if correct, please enter Yes. If not please enter No", LoanInterestRate);
                answer = ReadLine().ToUpper().Trim();

                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified the interest rate.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        LoanInterestRate = 0.00;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto setvalue;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }

            WriteLine("loan interest rate was set for: {0:P}", LoanInterestRate);
        }
        #endregion

        #region Get loan interest

        public string[] GetLoanInterestRate()
        {
            string[] loanInterest = { "Your Loan annual interest rate is: " + "\t" + LoanInterestRate.ToString("P"), " " };
            return loanInterest;
        }
        #endregion

        #region set HOA
        public void SetHOAFee()
        {
            YearlyHOAFee = -1;
            setvalue:
            while (YearlyHOAFee < 0)
            {
                WriteLine("Please enter the yearly Dollar amount for HOA. if No HOA amount enter 0.00:");
                try
                {
                    YearlyHOAFee = Convert.ToDouble(ReadLine());
                    if (YearlyHOAFee < 0)
                    {
                        throw new ArithmeticException("Amount cannot be less than $0.00. Please try again");

                    }

                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }
            string answer = " ";
            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                Console.WriteLine("Your input was {0:C}. Is this correct? if correct, please enter Yes. If not please enter No", YearlyHOAFee);
                answer = ReadLine().ToUpper().Trim();

                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified your yearly HOA.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        YearlyHOAFee = -1;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto setvalue;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }
                        
            WriteLine("HOA Value was set for: {0:C}.", YearlyHOAFee);
        }
        #endregion

        #region get HOA

        public string[] GetHOA()
        {
            string[] yearlyHoa = { "Yearly HOA fee is: " + "\t\t\t" + YearlyHOAFee.ToString("C"), " " };
            return yearlyHoa;
        }
        #endregion

        #region set Monthly Income 

        public void SetMonthlyIncome()
        {
            BuyersMonthlyIncome = 0;
            setvalue:
            while (BuyersMonthlyIncome <= 0)
            {
                WriteLine("Please enter Buyer's monthly income amount: ");
                try
                {
                    BuyersMonthlyIncome = Convert.ToDouble(ReadLine());
                    if (BuyersMonthlyIncome < 0)
                    {
                        throw new ArithmeticException("Amount has to be more than $0.00. Please try again");

                    }

                }
                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }
            }
            string answer = " ";
            while (answer != "Y" && answer != "N" && answer != "YES" && answer != "NO")
            {
                WriteLine("Your input was {0:C}. Is this correct? if correct, please enter Yes. If not please enter No", BuyersMonthlyIncome);
                answer = ReadLine().ToUpper().Trim();

                try
                {
                    if (answer == "Y" || answer == "YES")
                    {
                        WriteLine("You have verified that the ammount is correct.");
                        break;
                    }
                    else if (answer == "N" || answer == "NO")
                    {
                        BuyersMonthlyIncome = 0.00;
                        WriteLine("I see you made a mistake. Please try again.");
                        goto setvalue;
                    }
                    else
                    {
                        WriteLine("Your input was incorrect please try again");
                    }
                }


                catch (Exception e)
                {

                    WriteLine(e.ToString());
                }
                finally
                {
                    WriteLine();
                }

            }

            WriteLine("Buyer's monthly income value was set for: {0:C}.", BuyersMonthlyIncome);
        }
        #endregion

        #region get income

        public string[] GetMonthlyIncome()
        {
            string[] monthlyIncome = { "Buyer's Monthly Income is: " + "\t\t"+ BuyersMonthlyIncome.ToString("C"), " " }; 
            return monthlyIncome;
        }
        #endregion
        // Calculation: 
        #region Loan Value formula
        public void LoanValueCalculation()
        {
            
            LoanValue = (HomePrice - DownPaymnet) + ((HomePrice - DownPaymnet) * 0.01) + 2500;

            WriteLine("Initial loan amount was set for: {0:C}.", LoanValue);
            WriteLine();
        }
        #endregion

        #region Get Loan Value
        public string[] GetLoanValue()
        {
            string[] loanValue = { "Initial loan amount is: " + "\t\t" + LoanValue.ToString("C"), " " };
            return loanValue;
        }
        #endregion

        #region Home Equity %
        public void HomeEquity()
        {
            EquityValue = (HomeMarketValue - (HomePrice - DownPaymnet));
            EquityValue /= HomeMarketValue;
            WriteLine("Your Home Equity is: {0:P}", EquityValue);
            WriteLine() ;


        }
        #endregion

        #region Get Home equity

        public string[] GetHomeEquity()
        {
            string[] homeEquity = { "Your home equity is: " + "\t\t\t" + EquityValue.ToString("P"), " " };
            return homeEquity;
        }

        #endregion

        #region Monthly HOA 
        public void MonthlyHoa()
        {
            MonthlyHoaCalculation = YearlyHOAFee / 12;
            WriteLine("Your estimated HOA monthly amount is: {0:C}", MonthlyHoaCalculation);
            WriteLine();
        }
        #endregion

        #region Get monthly HOA

        public string[] GetMonthlyHoa()
        {
            string[] monthlyHoa = { "Monthly HOA amount: " + "\t\t\t\t\t\t" + MonthlyHoaCalculation.ToString("C"), " " };
            return monthlyHoa;
        }
        
        #endregion

        #region Property Tax
        public void IPropertyTax()
        {
            InitialPropertyTax = (HomeMarketValue * 0.0125) / 12;
            WriteLine("Your initial property tax is estimated at: {0:C}", InitialPropertyTax);
            WriteLine();

        }

        #endregion

        #region Get Property Tax

        public string[] GetPropertyTax()
        {
            string[] propertyTax = { "Property Tax: " + "\t\t\t\t\t\t\t" + InitialPropertyTax.ToString("C"), " " };
            return propertyTax;
        }

        #endregion

        #region Loan insurance

        public void LoanIns()
        {
            if (EquityValue < 0.10)
            {
                double initialLoanValue = HomePrice - DownPaymnet;
                LoanInsurance = (initialLoanValue * 0.01) / 12;
                WriteLine("Your Home Equity is less than 10.00%, your monthly Loan insurance amount is: {0:C}", LoanInsurance);
                WriteLine();
            }
            else
            {
                LoanInsurance = 0.00;
                WriteLine("Your Home Equity is more than 10%, Loan insurance is not necessary!");
                WriteLine();
            }
            
        }
#endregion

        #region get Loan Insurance 
        public string[] GetLoanIns()
        {
            string[] loanIns = { "Loan insurance: " + "\t\t\t\t\t\t\t" +LoanInsurance.ToString("C"), " " };
            return loanIns;
        }

        #endregion

        #region Home insurance 
        public void HomeIns()
        {
            HomeInsurance = (HomeMarketValue * 0.0075) / 12;
            WriteLine("Your estimated Home Insurance monthly amount is: {0:C}", HomeInsurance);
            WriteLine();
        }

        #endregion

        #region Get Home insurance

        public string[] GetHomeInsurance()
        {
            string[] homeIns = { "Home insurance: " + "\t\t\t\t\t\t\t" + HomeInsurance.ToString("C"), " " };
                return homeIns;
        }

#endregion

        #region Monthly Loan payment 

        public void MonthlyLoanPmt()
        {
            double interestRate = LoanInterestRate / 12;
            double noOfPmnt = TermOfLoan * 12;
            LoanMonthlyPayment = (interestRate * LoanValue) / (1 - Math.Pow(1 + interestRate, noOfPmnt * -1));

            WriteLine("Your monthly loan Payment before escrow is: {0:C}", LoanMonthlyPayment);
            WriteLine();    
        }
        #endregion

        #region Get Monthly Loan Payment

        public string[] GetMonthlyLoanPayment()
        {
            string[] monthlyPayment =
                { "initial Payment (Principal + Interest): " + "\t\t\t" + LoanMonthlyPayment.ToString("C"), " ", "\tEscrow:", " " };
            return monthlyPayment;
        }
#endregion 

        #region Final estimated total amount 
        public void TotalMonthlyPmt()
        {
            LoanpmtPlusEscrow = LoanMonthlyPayment + HomeInsurance + InitialPropertyTax + MonthlyHoaCalculation + LoanInsurance;

            WriteLine("Your estimated total monthly payment with escrow is: {0:C}", LoanpmtPlusEscrow);
            WriteLine();
        }

        #endregion

        #region Get final estimated amount

        public string[] GetTotalMonthlyPmt()
        {
            string[] getTotalMonhlyPmt =
                { "Final estimated monthly payment " + "\t\t\t\t" + LoanpmtPlusEscrow.ToString("C"), " " };
            return getTotalMonhlyPmt;
        }

#endregion

        #region Calculating approval or denial

        public void ApprovalCalculation()
        {
            PaymentIncomeratio = (LoanpmtPlusEscrow / BuyersMonthlyIncome);
            

            if (PaymentIncomeratio >= 0.25)
            {
                WriteLine("Your total payment to income ration is: {0:P}. Unfortunately you do not qualify for this loan. Our policy states that the debt to income ratio should be less than 25%", PaymentIncomeratio);
                WriteLine("Please consider increasing your down payment or buying a more affordable home.");
                WriteLine();
            }
            else
            {
                WriteLine("Congratulations! you have been approved for this loan. Your debt to income ratio is: {0:P}", PaymentIncomeratio);
            }
            
        }

        #endregion

        #region  Get approval or Denial

        public string[] GetApproval()
        {
            string[] approval = new string[2];

            if (PaymentIncomeratio >= 0.25)
            {
                approval[0] = "Buyer does not qualify for the loan. Total payment to income ration is: " + PaymentIncomeratio.ToString("P");
                approval[1] = "Please consider increasing the down payment or buying a more affordable home.";
            }

            else
            {
                approval[0] = "Congratulations! you have been approved for this loan. Your debt to income ratio is: " + PaymentIncomeratio.ToString("P");
                approval[1] = "Thank you for utilizing my first Mortgage Calculator";
            }

            return approval;
        }

        #endregion

        // Writing to a text 
        #region Writing to a text methods
        public string[] LoanSummary()
        {
            string[] loanSummary = { "\t\t\t\t\tLoan Summary:", " " };
            return loanSummary;

        }

        public string[] FinalCalculation()
        {
            string[] finalCalculation = { "\t\t\t\t\tFinal monthly Calculation:", " ", " " };
            return finalCalculation;
        }

        public string[] FinalLine()
        {
            string[] finalLine = { "\t\t\t\t\t\t\t\t\t" + "__________"};
            return finalLine;
        }
#endregion
        
    }
}