using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockTransaction
{
    public int Id { get; set; }

    public string EmpCode { get; set; } = null!;

    public DateTime PunchTime { get; set; }

    public string PunchState { get; set; } = null!;

    public int VerifyType { get; set; }

    public string? WorkCode { get; set; }

    public string? TerminalSn { get; set; }

    public string? TerminalAlias { get; set; }

    public string? AreaAlias { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? GpsLocation { get; set; }

    public string? Mobile { get; set; }

    public short? Source { get; set; }

    public short? Purpose { get; set; }

    public string? Crc { get; set; }

    public short? IsAttendance { get; set; }

    public string? Reserved { get; set; }

    public DateTime? UploadTime { get; set; }

    public short? SyncStatus { get; set; }

    public DateTime? SyncTime { get; set; }

    public short? IsMask { get; set; }

    public decimal? Temperature { get; set; }

    public int? EmpId { get; set; }

    public int? TerminalId { get; set; }

    public virtual ICollection<AttPayloadeffectpunch> AttPayloadeffectpunches { get; } = new List<AttPayloadeffectpunch>();

    public virtual ICollection<AttPayloadparing> AttPayloadparingInTrans { get; } = new List<AttPayloadparing>();

    public virtual ICollection<AttPayloadparing> AttPayloadparingOutTrans { get; } = new List<AttPayloadparing>();

    public virtual ICollection<AttPayloadpunch> AttPayloadpunches { get; } = new List<AttPayloadpunch>();

    public virtual IclockTerminal? Terminal { get; set; }
}
