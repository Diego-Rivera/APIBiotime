using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollPayrollpayloadpaycode
{
    public int Id { get; set; }

    public double? Amount { get; set; }

    public string? Formula { get; set; }

    public string? FormulaName { get; set; }

    public int PayCodeId { get; set; }

    public int PayloadId { get; set; }

    public virtual AttPaycode PayCode { get; set; } = null!;

    public virtual PayrollPayrollpayload Payload { get; set; } = null!;
}
