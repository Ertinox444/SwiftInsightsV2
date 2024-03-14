using System;
using System.Collections.Generic;

namespace SwiftInsightsV2.Entities;

public partial class User
{
    public int IdUser { get; set; }

    public string LoginUser { get; set; } = null!;

    public string PasswordUser { get; set; } = null!;

    public int IsAdmin { get; set; }
}
