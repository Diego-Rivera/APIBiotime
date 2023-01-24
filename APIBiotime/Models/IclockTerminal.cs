using System;
using System.Collections.Generic;
using System.Net;

namespace APIBiotime.Models;

public partial class IclockTerminal
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Sn { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public IPAddress IpAddress { get; set; } = null!;

    public IPAddress? RealIp { get; set; }

    public int State { get; set; }

    public short TerminalTz { get; set; }

    public int Heartbeat { get; set; }

    public short TransferMode { get; set; }

    public int TransferInterval { get; set; }

    public string TransferTime { get; set; } = null!;

    public short? ProductType { get; set; }

    public short IsAttendance { get; set; }

    public short IsRegistration { get; set; }

    public short? Purpose { get; set; }

    public short? ControllerType { get; set; }

    public short Authentication { get; set; }

    public string? Style { get; set; }

    public string? UploadFlag { get; set; }

    public string? FwVer { get; set; }

    public string PushProtocol { get; set; } = null!;

    public string? PushVer { get; set; }

    public int? Language { get; set; }

    public bool IsTft { get; set; }

    public string? TerminalName { get; set; }

    public string? Platform { get; set; }

    public string? OemVendor { get; set; }

    public string? LogStamp { get; set; }

    public string? OpLogStamp { get; set; }

    public string? CaptureStamp { get; set; }

    public int? UserCount { get; set; }

    public int? TransactionCount { get; set; }

    public int? FpCount { get; set; }

    public string? FpAlgVer { get; set; }

    public int? FaceCount { get; set; }

    public string? FaceAlgVer { get; set; }

    public int? FvCount { get; set; }

    public string? FvAlgVer { get; set; }

    public int? PalmCount { get; set; }

    public string? PalmAlgVer { get; set; }

    public short LockFunc { get; set; }

    public DateTime? LastActivity { get; set; }

    public DateTime? UploadTime { get; set; }

    public DateTime? PushTime { get; set; }

    public short IsAccess { get; set; }

    public int? AreaId { get; set; }

    public virtual ICollection<AccAccterminal> AccAccterminals { get; } = new List<AccAccterminal>();

    public virtual PersonnelArea? Area { get; set; }

    public virtual ICollection<EpEptransaction> EpEptransactions { get; } = new List<EpEptransaction>();

    public virtual ICollection<IclockErrorcommandlog> IclockErrorcommandlogs { get; } = new List<IclockErrorcommandlog>();

    public virtual ICollection<IclockPublicmessage> IclockPublicmessages { get; } = new List<IclockPublicmessage>();

    public virtual ICollection<IclockTerminalcommandlog> IclockTerminalcommandlogs { get; } = new List<IclockTerminalcommandlog>();

    public virtual ICollection<IclockTerminalcommand> IclockTerminalcommands { get; } = new List<IclockTerminalcommand>();

    public virtual ICollection<IclockTerminallog> IclockTerminallogs { get; } = new List<IclockTerminallog>();

    public virtual ICollection<IclockTerminalparameter> IclockTerminalparameters { get; } = new List<IclockTerminalparameter>();

    public virtual ICollection<IclockTerminaluploadlog> IclockTerminaluploadlogs { get; } = new List<IclockTerminaluploadlog>();

    public virtual ICollection<IclockTransactionproofcmd> IclockTransactionproofcmds { get; } = new List<IclockTransactionproofcmd>();

    public virtual ICollection<IclockTransaction> IclockTransactions { get; } = new List<IclockTransaction>();

    public virtual MeetingMeetingroomdevice? MeetingMeetingroomdevice { get; set; }

    public virtual ICollection<MeetingMeetingtransaction> MeetingMeetingtransactions { get; } = new List<MeetingMeetingtransaction>();

    public virtual ICollection<VisitorVisitortransaction> VisitorVisitortransactions { get; } = new List<VisitorVisitortransaction>();
}
