using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollSalaryadvance
{
    public int Id { get; set; }

    public double AdvanceAmount { get; set; }

    public DateTime AdvanceTime { get; set; }

    public string? AdvanceRemark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}
