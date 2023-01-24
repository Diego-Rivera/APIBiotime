using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseEventalertsetting
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int EventId { get; set; }

    public string Event { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string SubModule { get; set; } = null!;

    public bool EmailAlert { get; set; }

    public bool AppAlert { get; set; }

    public bool SmsAlert { get; set; }

    public bool WhatappAlert { get; set; }
}
