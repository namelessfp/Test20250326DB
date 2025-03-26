using System;
using System.Collections.Generic;

namespace Byron20250326DB.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    public string WarehouseName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
