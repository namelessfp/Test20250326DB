using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Byron20250326DB.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }
    [Display(Name = "Bodega nombre")]
    public string WarehouseName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
