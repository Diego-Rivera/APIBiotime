using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccountsUsernotification
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public DateTime SendTime { get; set; }

    public DateTime? ReadTime { get; set; }

    public short Status { get; set; }

    public int UserId { get; set; }

    public int? Category { get; set; }

    public int? Event { get; set; }
}
