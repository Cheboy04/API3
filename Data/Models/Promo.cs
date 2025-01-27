﻿using System;
using System.Collections.Generic;

namespace API3.Data.Models;

public partial class Promo
{
    public int PromoId { get; set; }

    public string? Description { get; set; }

    public DateTime FechaPromo { get; set; }

    public int BurgerId { get; set; }

    public virtual Burger Burger { get; set; } = null!;
}
