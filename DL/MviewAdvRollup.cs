using System;
using System.Collections.Generic;

namespace DL;

public partial class MviewAdvRollup
{
    public decimal Runid { get; set; }

    public decimal Clevelid { get; set; }

    public decimal Plevelid { get; set; }

    public decimal Flags { get; set; }

    public virtual MviewAdvLevel MviewAdvLevel { get; set; } = null!;

    public virtual MviewAdvLevel MviewAdvLevelNavigation { get; set; } = null!;

    public virtual MviewAdvLog Run { get; set; } = null!;
}
