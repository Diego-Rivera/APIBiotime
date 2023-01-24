using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class BaseBookmark
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Filters { get; set; } = null!;

    public bool IsShare { get; set; }

    public DateTime TimeSaved { get; set; }

    public int ContentTypeId { get; set; }

    public int? UserId { get; set; }

    public virtual DjangoContentType ContentType { get; set; } = null!;

    public virtual AuthUser? User { get; set; }
}
