using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class MeetingMeetingentityAttender
{
    public int Id { get; set; }

    public int MeetingentityId { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual MeetingMeetingentity Meetingentity { get; set; } = null!;
}
