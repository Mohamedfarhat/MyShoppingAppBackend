using System;
using System.Collections.Generic;

#nullable disable

namespace MyShoppingAppBackend.Model
{
    public partial class FeatureImg
    {
        public int FeatureImgId { get; set; }
        public string FeatureImgUrl { get; set; }
        public int? CategoryId { get; set; }
    }
}
