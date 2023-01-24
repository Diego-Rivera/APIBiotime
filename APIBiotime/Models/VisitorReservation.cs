using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class VisitorReservation
{
    public int WorkflowinstancePtrId { get; set; }

    public string? VisFirstName { get; set; }

    public string? VisLastName { get; set; }

    public string CertNo { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Company { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int VisitQuantity { get; set; }

    public DateTime VisitDate { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? ApplyReason { get; set; }

    public int CertTypeId { get; set; }

    public int? VisitDepartmentId { get; set; }

    public int? VisitReasonId { get; set; }

    public string? Email { get; set; }

    public virtual PersonnelCertification CertType { get; set; } = null!;

    public virtual PersonnelDepartment? VisitDepartment { get; set; }

    public virtual VisitorReason? VisitReason { get; set; }

    public virtual WorkflowWorkflowinstance WorkflowinstancePtr { get; set; } = null!;
}
