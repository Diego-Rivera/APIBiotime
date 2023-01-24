using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttReporttemplate
{
    public int Id { get; set; }

    public string Report { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public string TemplateValue { get; set; } = null!;

    public bool IsShare { get; set; }

    public bool IsAutoExport { get; set; }

    public int? BuilderId { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public bool FixedDatePeriod { get; set; }

    public string Language { get; set; } = null!;

    public short Status { get; set; }

    public int? EmployeeId { get; set; }

    public virtual AuthUser? Builder { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}
