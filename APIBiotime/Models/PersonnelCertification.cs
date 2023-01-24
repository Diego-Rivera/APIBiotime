using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class PersonnelCertification
{
    public int Id { get; set; }

    public string CertCode { get; set; } = null!;

    public string CertName { get; set; } = null!;

    public virtual ICollection<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; } = new List<PersonnelEmployeecertification>();

    public virtual ICollection<VisitorReservation> VisitorReservations { get; } = new List<VisitorReservation>();

    public virtual ICollection<VisitorVisitor> VisitorVisitors { get; } = new List<VisitorVisitor>();
}
