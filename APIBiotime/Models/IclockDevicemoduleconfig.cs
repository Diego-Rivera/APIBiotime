using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class IclockDevicemoduleconfig
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public bool EnableRegistration { get; set; }

    public bool EnableResignedFilter { get; set; }

    public bool EnableAutoAdd { get; set; }

    public bool EnableNameUpload { get; set; }

    public bool EnableNameDownload { get; set; }

    public bool EnableCardUpload { get; set; }

    public bool Encryption { get; set; }

    public short Timezone { get; set; }

    public bool GlobalSetup { get; set; }

    public int Heartbeat { get; set; }

    public short TransferMode { get; set; }

    public int TransferInterval { get; set; }

    public string TransferTime { get; set; } = null!;

    public int TransactionRetention { get; set; }

    public int CommandRetention { get; set; }

    public int DevLogRetention { get; set; }

    public int UploadLogRetention { get; set; }

    public short EditPolicy { get; set; }

    public short ImportPolicy { get; set; }

    public short MobilePolicy { get; set; }

    public short DevicePolicy { get; set; }

    public short ApiPolicy { get; set; }

    public short SyncMode { get; set; }

    public string SyncTime { get; set; } = null!;

    public short VisitorPolicy { get; set; }
}
