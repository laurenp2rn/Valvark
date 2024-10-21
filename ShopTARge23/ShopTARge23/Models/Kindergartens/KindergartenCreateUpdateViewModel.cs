using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ShopTARge23.Models.Kindergartens
{
    public class KindergartenCreateUpdateViewModel
    {
        public Guid? Id { get; set; }
        public string GroupName { get; set; }
        public int ChildrenCount { get; set; }
        public string KindergartenName { get; set; }
        public string Teacher { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IFormFileCollection Files { get; set; } // Failide kogum

        public List<KindergartenImageViewModel> Image { get; set; } = new(); // Õige tüüp
    }
}
