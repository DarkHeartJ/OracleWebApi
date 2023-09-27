using System;
using System.Collections.Generic;

namespace DL;

public partial class MviewAdvAjg
{
    public decimal Ajgid { get; set; }

    public decimal Runid { get; set; }

    public decimal Ajgdeslen { get; set; }

    public byte[] Ajgdes { get; set; } = null!;

    public decimal Hashvalue { get; set; }

    public decimal? Frequency { get; set; }

    public virtual ICollection<MviewAdvFjg> MviewAdvFjgs { get; set; } = new List<MviewAdvFjg>();

    public virtual MviewAdvLog Run { get; set; } = null!;
}
