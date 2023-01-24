using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollSalarystructureOvertimeformula
{
    public int Id { get; set; }

    public int SalarystructureId { get; set; }

    public int OvertimeformulaId { get; set; }

    public virtual PayrollOvertimeformula Overtimeformula { get; set; } = null!;

    public virtual PayrollSalarystructure Salarystructure { get; set; } = null!;
}
