using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccountsAdminbiodatum
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string BioTmp { get; set; } = null!;

    public int? BioNo { get; set; }

    public int? BioIndex { get; set; }

    public int BioType { get; set; }

    public string MajorVer { get; set; } = null!;

    public string? MinorVer { get; set; }

    public int? BioFormat { get; set; }

    public bool Valid { get; set; }

    public bool Duress { get; set; }

    public int AdminId { get; set; }

    public virtual AuthUser Admin { get; set; } = null!;
}
