using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileGpsfordepartmentLocation
{
    public int Id { get; set; }

    public int GpsfordepartmentId { get; set; }

    public int GpslocationId { get; set; }

    public virtual MobileGpsfordepartment Gpsfordepartment { get; set; } = null!;

    public virtual MobileGpslocation Gpslocation { get; set; } = null!;
}
