using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class WorkflowWorkflowengine
{
    public int Id { get; set; }

    public string WorkflowCode { get; set; } = null!;

    public string WorkflowName { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Description { get; set; } = null!;

    public short WorkflowType { get; set; }

    public int? ApplicantPositionId { get; set; }

    public int? ContentTypeId { get; set; }

    public int? DepartmentsId { get; set; }

    public virtual PersonnelPosition? ApplicantPosition { get; set; }

    public virtual DjangoContentType? ContentType { get; set; }

    public virtual PersonnelDepartment? Departments { get; set; }

    public virtual ICollection<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; } = new List<WorkflowWorkflowengineEmployee>();

    public virtual ICollection<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; } = new List<WorkflowWorkflowinstance>();

    public virtual ICollection<WorkflowWorkflownode> WorkflowWorkflownodes { get; } = new List<WorkflowWorkflownode>();
}
