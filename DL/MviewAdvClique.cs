using System;
using System.Collections.Generic;

namespace DL;

public partial class MviewAdvClique
{
    public decimal Cliqueid { get; set; }

    public decimal Runid { get; set; }

    public decimal Cliquedeslen { get; set; }

    public byte[] Cliquedes { get; set; } = null!;

    public decimal Hashvalue { get; set; }

    public decimal Frequency { get; set; }

    public decimal Bytecost { get; set; }

    public decimal Rowsize { get; set; }

    public decimal Numrows { get; set; }

    public virtual MviewAdvLog Run { get; set; } = null!;
}
