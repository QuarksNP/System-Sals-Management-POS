﻿using System;

namespace itlapr.DAL.Entities.Core
{
    public abstract class AuditEntity
    {
        public AuditEntity()
        {
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }
        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
        public int? UserMod { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool Deleted { get; set; }
    }
}