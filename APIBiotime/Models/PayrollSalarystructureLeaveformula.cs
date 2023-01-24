using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollSalarystructureLeaveformula
{
    public int Id { get; set; }

    public int SalarystructureId { get; set; }

    public int LeaveformulaId { get; set; }

    public virtual PayrollLeaveformula Leaveformula { get; set; } = null!;

    public virtual PayrollSalarystructure Salarystructure { get; set; } = null!;
}
