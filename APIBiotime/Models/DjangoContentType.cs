using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class DjangoContentType
{
    public int Id { get; set; }

    public string AppLabel { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ICollection<BaseAdminlog> BaseAdminlogs { get; } = new List<BaseAdminlog>();

    public virtual ICollection<BaseApilog> BaseApilogs { get; } = new List<BaseApilog>();

    public virtual ICollection<BaseBookmark> BaseBookmarks { get; } = new List<BaseBookmark>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; } = new List<DjangoAdminLog>();

    public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; } = new List<GuardianGroupobjectpermission>();

    public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; } = new List<GuardianUserobjectpermission>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; } = new List<WorkflowWorkflowengine>();
}
