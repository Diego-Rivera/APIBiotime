using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseSecuritypolicy
{
    public int Id { get; set; }

    public bool SingleLogin { get; set; }

    public bool SecurityCode { get; set; }

    public int CodeLength { get; set; }

    public int ValidDuration { get; set; }

    public bool FailedLocked { get; set; }

    public int LockFailedCount { get; set; }

    public int LockDuration { get; set; }

    public bool EnforcePwdChange { get; set; }

    public bool EnforcePwdExpiration { get; set; }

    public int ValidityPeriod { get; set; }

    public short PasswordLevel { get; set; }

    public bool IsDefault { get; set; }

    public bool AppSingleUserLogin { get; set; }

    public int SessionTimeout { get; set; }

    public bool ExportEncryption { get; set; }

    public string? ExportEncryptionPassword { get; set; }
}
