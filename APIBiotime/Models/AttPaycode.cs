using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttPaycode
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short CodeType { get; set; }

    public short? Tag { get; set; }

    public short? FixedCode { get; set; }

    public bool IsWork { get; set; }

    public decimal FixedHours { get; set; }

    public bool IsPaid { get; set; }

    public bool IsBenefit { get; set; }

    public short RoundOff { get; set; }

    public decimal MinVal { get; set; }

    public short DisplayFormat { get; set; }

    public string? Symbol { get; set; }

    public short DisplayOrder { get; set; }

    public string? Desc { get; set; }

    public bool IsDisplay { get; set; }

    public bool IsDefault { get; set; }

    public string? ColorSetting { get; set; }

    public virtual ICollection<AttAttpolicy> AttAttpolicies { get; } = new List<AttAttpolicy>();

    public virtual ICollection<AttBreaktime> AttBreaktimeLossCodes { get; } = new List<AttBreaktime>();

    public virtual ICollection<AttBreaktime> AttBreaktimeProfitCodes { get; } = new List<AttBreaktime>();

    public virtual ICollection<AttDepartmentpolicy> AttDepartmentpolicies { get; } = new List<AttDepartmentpolicy>();

    public virtual ICollection<AttGrouppolicy> AttGrouppolicies { get; } = new List<AttGrouppolicy>();

    public virtual ICollection<AttLeavegroupdetail> AttLeavegroupdetails { get; } = new List<AttLeavegroupdetail>();

    public virtual ICollection<AttLeave> AttLeaves { get; } = new List<AttLeave>();

    public virtual ICollection<AttLeaveyearbalance> AttLeaveyearbalances { get; } = new List<AttLeaveyearbalance>();

    public virtual ICollection<AttOvertimepolicy> AttOvertimepolicyOvernightPayCodes { get; } = new List<AttOvertimepolicy>();

    public virtual ICollection<AttOvertimepolicy> AttOvertimepolicyPayCodes { get; } = new List<AttOvertimepolicy>();

    public virtual ICollection<AttOvertime> AttOvertimes { get; } = new List<AttOvertime>();

    public virtual ICollection<AttPayloadparing> AttPayloadparings { get; } = new List<AttPayloadparing>();

    public virtual ICollection<AttPayloadpaycode> AttPayloadpaycodes { get; } = new List<AttPayloadpaycode>();

    public virtual ICollection<AttTimeinterval> AttTimeintervals { get; } = new List<AttTimeinterval>();

    public virtual ICollection<AttTraining> AttTrainings { get; } = new List<AttTraining>();

    public virtual ICollection<PayrollExceptionformula> PayrollExceptionformulas { get; } = new List<PayrollExceptionformula>();

    public virtual ICollection<PayrollLeaveformula> PayrollLeaveformulas { get; } = new List<PayrollLeaveformula>();

    public virtual ICollection<PayrollOvertimeformula> PayrollOvertimeformulas { get; } = new List<PayrollOvertimeformula>();

    public virtual ICollection<PayrollPayrollpayloadpaycode> PayrollPayrollpayloadpaycodes { get; } = new List<PayrollPayrollpayloadpaycode>();

    public virtual ICollection<PersonnelEmployeeleavebalance> PersonnelEmployeeleavebalances { get; } = new List<PersonnelEmployeeleavebalance>();
}
