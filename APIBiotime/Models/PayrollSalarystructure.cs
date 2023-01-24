using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PayrollSalarystructure
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public double SalaryAmount { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public string? SalaryRemark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }

    public virtual ICollection<PayrollSalarystructureDeductionformula> PayrollSalarystructureDeductionformulas { get; } = new List<PayrollSalarystructureDeductionformula>();

    public virtual ICollection<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; } = new List<PayrollSalarystructureExceptionformula>();

    public virtual ICollection<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; } = new List<PayrollSalarystructureIncreasementformula>();

    public virtual ICollection<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; } = new List<PayrollSalarystructureLeaveformula>();

    public virtual ICollection<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; } = new List<PayrollSalarystructureOvertimeformula>();
}
