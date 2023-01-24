using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseAutoimporttask
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string TaskCode { get; set; } = null!;

    public string TaskName { get; set; } = null!;

    public string? Params { get; set; }

    public bool Enable { get; set; }

    public DateTime? ProcessTime { get; set; }

    public int CompanyId { get; set; }

    public virtual PersonnelCompany Company { get; set; } = null!;
}
