using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileAnnouncement
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public string Content { get; set; } = null!;

    public short Category { get; set; }

    public string? Sender { get; set; }

    public string? SystemSender { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? AdminId { get; set; }

    public int? InitSenderId { get; set; }

    public int? ReceiverId { get; set; }

    public virtual AuthUser? Admin { get; set; }

    public virtual PersonnelEmployee? InitSender { get; set; }

    public virtual PersonnelEmployee? Receiver { get; set; }
}
