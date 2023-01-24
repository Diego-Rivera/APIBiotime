using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollSalarystructureIncreasementformula
{
    public int Id { get; set; }

    public int SalarystructureId { get; set; }

    public int IncreasementformulaId { get; set; }

    public virtual PayrollIncreasementformula Increasementformula { get; set; } = null!;

    public virtual PayrollSalarystructure Salarystructure { get; set; } = null!;
}
