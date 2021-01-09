using System;
using System.Collections.Generic;

#nullable disable

namespace MyShoppingAppBackend.Model
{
    public partial class Size
    {
        public Size()
        {
            ProductSizes = new HashSet<ProductSize>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<ProductSize> ProductSizes { get; set; }
    }
}
