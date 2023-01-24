using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AttOvertimepolicy
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public short Mode { get; set; }

    public decimal HrsFrom { get; set; }

    public decimal HrsTo { get; set; }

    public Guid Master { get; set; }

    public int? OvernightPayCodeId { get; set; }

    public int? PayCodeId { get; set; }

    public virtual AttPaycode? OvernightPayCode { get; set; }

    public virtual AttPaycode? PayCode { get; set; }
}
