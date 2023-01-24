using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollPayrollpayload
{
    public int Id { get; set; }

    public DateOnly? CalcTime { get; set; }

    public double? BasicSalary { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public string? FormatDict { get; set; }

    public short? PaymentMode { get; set; }

    public double? Increase { get; set; }

    public double? Deduction { get; set; }

    public string? IncreaseFormula { get; set; }

    public string? DeductionFormula { get; set; }

    public string? IncreaseFormulaName { get; set; }

    public string? DeductionFormulaName { get; set; }

    public double? ExtraIncrease { get; set; }

    public double? ExtraDeduction { get; set; }

    public double? TotalLoanAmount { get; set; }

    public double? RefundLoanAmount { get; set; }

    public double? UnrefundLoanAmount { get; set; }

    public double? LoanDeduction { get; set; }

    public double? LoanIncrease { get; set; }

    public double? AdvanceIncrease { get; set; }

    public double? AdvanceDeduction { get; set; }

    public double? Reimbursement { get; set; }

    public string? TotalIncreaseFormula { get; set; }

    public string? TotalIncreaseFormulaName { get; set; }

    public string? TotalIncreaseExpression { get; set; }

    public double? TotalIncrease { get; set; }

    public string? TotalDeductionFormula { get; set; }

    public string? TotalDeductionFormulaName { get; set; }

    public string? TotalDeductionExpression { get; set; }

    public double? TotalDeduction { get; set; }

    public string? TotalSalaryExpression { get; set; }

    public double? TotalSalary { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual ICollection<PayrollPayrollpayloadpaycode> PayrollPayrollpayloadpaycodes { get; } = new List<PayrollPayrollpayloadpaycode>();
}
