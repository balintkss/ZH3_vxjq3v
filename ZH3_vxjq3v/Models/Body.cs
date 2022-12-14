using System;
using System.Collections.Generic;

namespace ZH3_vxjq3v.Models;

public partial class Body
{
    public int BodyTypeId { get; set; }

    public string BodyType { get; set; } = null!;

    public virtual ICollection<Cars> Cars { get; } = new List<Cars>();
}
