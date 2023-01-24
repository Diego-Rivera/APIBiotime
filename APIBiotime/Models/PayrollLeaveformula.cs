using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollLeaveformula
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Formula { get; set; } = null!;

    public string? Remark { get; set; }

    public int PayCodeId { get; set; }

    public virtual AttPaycode PayCode { get; set; } = null!;

    public virtual ICollection<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; } = new List<PayrollSalarystructureLeaveformula>();
}
