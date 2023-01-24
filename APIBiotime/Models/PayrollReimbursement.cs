using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollReimbursement
{
    public int Id { get; set; }

    public double RmbAmount { get; set; }

    public DateTime RmbTime { get; set; }

    public string? RmbFile { get; set; }

    public string? RmbRemark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}
