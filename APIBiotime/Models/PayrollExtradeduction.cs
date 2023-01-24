using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollExtradeduction
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public double Amount { get; set; }

    public DateTime IssuedTime { get; set; }

    public string? Remark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}
