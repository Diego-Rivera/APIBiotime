using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollSalarystructureDeductionformula
{
    public int Id { get; set; }

    public int SalarystructureId { get; set; }

    public int DeductionformulaId { get; set; }

    public virtual PayrollDeductionformula Deductionformula { get; set; } = null!;

    public virtual PayrollSalarystructure Salarystructure { get; set; } = null!;
}
