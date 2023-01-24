using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthUserProfile
{
    public int Id { get; set; }

    public string LoginName { get; set; } = null!;

    public string PinTabs { get; set; } = null!;

    public string DisabledFields { get; set; } = null!;

    public string ColumnOrder { get; set; } = null!;

    public string Preferences { get; set; } = null!;

    public DateTime? PwdUpdateTime { get; set; }

    public int UserId { get; set; }
}
