using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AccAcccombination
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int CombinationNo { get; set; }

    public string CombinationName { get; set; } = null!;

    public int? Group1 { get; set; }

    public int? Group2 { get; set; }

    public int? Group3 { get; set; }

    public int? Group4 { get; set; }

    public int? Group5 { get; set; }

    public string? Remark { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int AreaId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;
}
