using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorVisitor
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string VisitorCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string CertNo { get; set; } = null!;

    public string? Photo { get; set; }

    public string? Password { get; set; }

    public string? CardNo { get; set; }

    public string? Gender { get; set; }

    public string? Company { get; set; }

    public string? Ssn { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public int VisitQuantity { get; set; }

    public string? EntryCarryingGoods { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime? ExitTime { get; set; }

    public string? ExitCarryingGoods { get; set; }

    public string? Remark { get; set; }

    public int CertTypeId { get; set; }

    public int? VisitDepartmentId { get; set; }

    public int? VisitReasonId { get; set; }

    public int VisitedId { get; set; }

    public virtual PersonnelCertification CertType { get; set; } = null!;

    public virtual ICollection<IclockVisitorbiodatum> IclockVisitorbiodata { get; } = new List<IclockVisitorbiodatum>();

    public virtual PersonnelDepartment? VisitDepartment { get; set; }

    public virtual VisitorReason? VisitReason { get; set; }

    public virtual PersonnelEmployee Visited { get; set; } = null!;

    public virtual ICollection<VisitorVisitorAccGroup> VisitorVisitorAccGroups { get; } = new List<VisitorVisitorAccGroup>();

    public virtual ICollection<VisitorVisitorArea> VisitorVisitorAreas { get; } = new List<VisitorVisitorArea>();

    public virtual ICollection<VisitorVisitorbiodatum> VisitorVisitorbiodata { get; } = new List<VisitorVisitorbiodatum>();

    public virtual ICollection<VisitorVisitorbiophoto> VisitorVisitorbiophotos { get; } = new List<VisitorVisitorbiophoto>();

    public virtual ICollection<VisitorVisitorlog> VisitorVisitorlogs { get; } = new List<VisitorVisitorlog>();

    public virtual ICollection<VisitorVisitortransaction> VisitorVisitortransactions { get; } = new List<VisitorVisitortransaction>();
}
