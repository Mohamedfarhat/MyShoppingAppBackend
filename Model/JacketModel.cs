using System;
using System.Collections.Generic;

#nullable disable

namespace MyShoppingAppBackend.Model
{
    public partial class JacketModel
    {
        public JacketModel()
        {
            ProductJacketModels = new HashSet<ProductJacketModel>();
        }

        public int JacketModelId { get; set; }
        public string JacketModelName { get; set; }

        public virtual ICollection<ProductJacketModel> ProductJacketModels { get; set; }
    }
}
