using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttLeavegroupdetail
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int LeaveType { get; set; }

    public int AllowLeaveDay { get; set; }

    public double MinLeaveDay { get; set; }

    public short DeductHolidayDay { get; set; }

    public int? LeaveEntitlement { get; set; }

    public int LeaveInterval { get; set; }

    public int? LeaveDistributionTime { get; set; }

    public string StartDay { get; set; } = null!;

    public short SetHireDay { get; set; }

    public short AllowExceedLimit { get; set; }

    public short AllowBalance { get; set; }

    public int? MaxBalance { get; set; }

    public string? EntitlementDetail { get; set; }

    public int LeaveGroupId { get; set; }

    public int? PayCodeId { get; set; }

    public virtual AttLeavegroup LeaveGroup { get; set; } = null!;

    public virtual AttPaycode? PayCode { get; set; }
}
