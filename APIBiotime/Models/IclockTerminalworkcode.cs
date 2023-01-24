using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTerminalworkcode
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Code { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public DateTime? LastActivity { get; set; }

    public int? CompanyId { get; set; }

    public virtual PersonnelCompany? Company { get; set; }
}
