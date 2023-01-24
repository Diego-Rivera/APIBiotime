using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseLinenotifysetting
{
    public int Id { get; set; }

    public int? IncludeSubDepartment { get; set; }

    public string? LineNotifyToken { get; set; }

    public int? MessageType { get; set; }

    public string? MessageHead { get; set; }

    public string? MessageTail { get; set; }

    public TimeOnly? PushTime { get; set; }

    public int? IsValid { get; set; }

    public string? Remark { get; set; }

    public int? LineNotifyDeptId { get; set; }

    public virtual PersonnelDepartment? LineNotifyDept { get; set; }
}
