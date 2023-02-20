﻿using itlapr.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace itlapr.DAL.Context
{
    public class ItlaContext : DbContext
    {
        public ItlaContext(DbContextOptions<ItlaContext> options) : base(options)
        {
        }
        #region "Sales.Orders"
        //El nombre debe coincidir con el de la bd.
        public DbSet<SalesOrders> SalesOrders { get; set; }
        #endregion
    }
}