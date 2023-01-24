using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class SyncEmployee
{
    public int Id { get; set; }

    public DateTime? PostTime { get; set; }

    public short Flag { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? SyncRet { get; set; }

    public string EmpCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? DeptCode { get; set; }

    public string? DeptName { get; set; }

    public string? JobCode { get; set; }

    public string? JobName { get; set; }

    public string? AreaCode { get; set; }

    public string? AreaName { get; set; }

    public string? CardNo { get; set; }

    public bool MultiArea { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Email { get; set; }

    public bool ActiveStatus { get; set; }
}
