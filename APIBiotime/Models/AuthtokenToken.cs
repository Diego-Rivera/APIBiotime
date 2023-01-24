using System;
using System.Collections.Generic;

namespace APIBiotime.Models;

public partial class AuthtokenToken
{
    public string Key { get; set; } = null!;

    public DateTime Created { get; set; }

    public int UserId { get; set; }
}
