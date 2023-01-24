using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileAppnotification
{
    public int Id { get; set; }

    public string? Sender { get; set; }

    public string? SystemSender { get; set; }

    public short Category { get; set; }

    public int? SubCategory { get; set; }

    public string? Content { get; set; }

    public string? Payload { get; set; }

    public int? Source { get; set; }

    public DateTime NotificationTime { get; set; }

    public short ReadStatus { get; set; }

    public DateTime? ReadTime { get; set; }

    public int? AdminId { get; set; }

    public int? InitSenderId { get; set; }

    public int ReceiverId { get; set; }

    public virtual AuthUser? Admin { get; set; }

    public virtual PersonnelEmployee? InitSender { get; set; }

    public virtual PersonnelEmployee Receiver { get; set; } = null!;
}
