using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileGpslocation
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Alias { get; set; } = null!;

    public string Location { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public virtual ICollection<MobileGpsfordepartmentLocation> MobileGpsfordepartmentLocations { get; } = new List<MobileGpsfordepartmentLocation>();

    public virtual ICollection<MobileGpsforemployeeLocation> MobileGpsforemployeeLocations { get; } = new List<MobileGpsforemployeeLocation>();
}
