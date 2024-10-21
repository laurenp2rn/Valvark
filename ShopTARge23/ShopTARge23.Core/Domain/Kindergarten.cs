﻿using System;
using System.Collections.Generic;

namespace ShopTARge23.Core.Domain
{
    public class Kindergarten
    {
        public Guid? Id { get; set; }
        public string GroupName { get; set; }
        public int ChildrenCount { get; set; }
        public string KindergartenName { get; set; }
        public string Teacher { get; set; }

        public ICollection<FileToDatabase> Images { get; set; } = new List<FileToDatabase>();

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
