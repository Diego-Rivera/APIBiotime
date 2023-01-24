using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollIncreasementformula
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Formula { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; } = new List<PayrollSalarystructureIncreasementformula>();
}
