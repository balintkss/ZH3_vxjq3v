using System;
using System.Collections.Generic;

namespace ZH3_vxjq3v.Models;

public partial class Engine
{
    public int EngineId { get; set; }

    public string EngineType { get; set; } = null!;

    public virtual ICollection<Cars> Cars { get; } = new List<Cars>();
}
