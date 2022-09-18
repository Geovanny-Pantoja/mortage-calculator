
#region Receiving and setting required values
Loan loan1 = new Loan();

//Home Market value
loan1.SetHmv();
WriteLine();

//Actual Home loan
loan1.SetHomePrice();
WriteLine();

// Loan term
loan1.SetTerm();// Loan term 
WriteLine();

loan1.SetDownPayment();
WriteLine();

loan1.SetHOAFee();
WriteLine();

loan1.SetLoanInterestRate();
WriteLine();

loan1.SetMonthlyIncome();

WriteLine();

#endregion

#region Calculating values 
loan1.LoanValueCalculation();

loan1.HomeEquity();

loan1.MonthlyHoa();

loan1.IPropertyTax();

loan1.LoanIns();

loan1.HomeIns();

loan1.MonthlyLoanPmt();

loan1.TotalMonthlyPmt();

loan1.ApprovalCalculation();

#endregion

#region  Writing to a text file

try
{

    File.WriteAllLines("C:\\temp\\loanSummary.txt", loan1.LoanSummary());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetHMV());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetHomePrice());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetDownPayment());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetLoanTerm());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetLoanInterestRate());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetHOA());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetMonthlyIncome());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetLoanValue());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetHomeEquity());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.FinalCalculation());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetLoanIns());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetMonthlyLoanPayment());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetMonthlyHoa());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetPropertyTax());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetHomeInsurance());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.FinalLine());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetTotalMonthlyPmt());
    File.AppendAllLines("C:\\temp\\loanSummary.txt", loan1.GetApproval());
}
catch (Exception e)
{
    WriteLine(e);
    
}




#endregion






