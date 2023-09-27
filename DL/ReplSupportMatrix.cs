using System;
using System.Collections.Generic;

namespace DL;

public partial class ReplSupportMatrix
{
    public string? FeatureName { get; set; }

    public decimal? ReasonCode { get; set; }

    public decimal Bmap1 { get; set; }

    public decimal Bmap2 { get; set; }

    public decimal ReplProduct { get; set; }

    public decimal SupportMode { get; set; }

    public decimal? MinCompat { get; set; }

    public decimal? MaxCompat { get; set; }
}
