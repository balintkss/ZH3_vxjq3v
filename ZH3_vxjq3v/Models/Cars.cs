using System;
using System.Collections.Generic;

namespace ZH3_vxjq3v.Models;

public partial class Cars
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public int BodyTypeId { get; set; }

    public int EngineId { get; set; }

    public int? NumberSeater { get; set; }

    public double? Acceleration { get; set; }

    public int? MaxSpeed { get; set; }

    public virtual Body BodyType { get; set; } = null!;

    public virtual Engine Engine { get; set; } = null!;
}
