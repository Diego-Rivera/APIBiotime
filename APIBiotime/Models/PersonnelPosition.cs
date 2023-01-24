using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelPosition
{
    public int Id { get; set; }

    public string PositionCode { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int? ParentPositionId { get; set; }

    public int CompanyId { get; set; }

    public virtual PersonnelCompany Company { get; set; } = null!;

    public virtual ICollection<PersonnelPosition> InverseParentPosition { get; } = new List<PersonnelPosition>();

    public virtual PersonnelPosition? ParentPosition { get; set; }

    public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; } = new List<PersonnelEmployee>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; } = new List<WorkflowWorkflowengine>();
}
