using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MobileGpsforemployeeLocation
{
    public int Id { get; set; }

    public int GpsforemployeeId { get; set; }

    public int GpslocationId { get; set; }

    public virtual MobileGpsforemployee Gpsforemployee { get; set; } = null!;

    public virtual MobileGpslocation Gpslocation { get; set; } = null!;
}
