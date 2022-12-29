﻿using System;
using System.Collections.Generic;

namespace HotelApi;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    
    public string Password { get; set; } = null!;

   // public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
