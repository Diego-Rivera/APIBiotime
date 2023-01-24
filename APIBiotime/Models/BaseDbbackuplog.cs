using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseDbbackuplog
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string DbType { get; set; } = null!;

    public string DbName { get; set; } = null!;

    public string? Operator { get; set; }

    public string BackupFile { get; set; } = null!;

    public DateTime BackupTime { get; set; }

    public short BackupStatus { get; set; }

    public string? Remark { get; set; }
}
