using System;
using System.Collections.Generic;

namespace DL;

public partial class MviewAdvGc
{
    public decimal Gcid { get; set; }

    public decimal Fjgid { get; set; }

    public decimal Gcdeslen { get; set; }

    public byte[] Gcdes { get; set; } = null!;

    public decimal Hashvalue { get; set; }

    public decimal? Frequency { get; set; }

    public virtual MviewAdvFjg Fjg { get; set; } = null!;
}
