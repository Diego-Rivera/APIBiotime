using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class SyncDepartment
{
    public int Id { get; set; }

    public DateTime? PostTime { get; set; }

    public short Flag { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? SyncRet { get; set; }

    public string DeptCode { get; set; } = null!;

    public string DeptName { get; set; } = null!;
}
