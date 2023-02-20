using itlapr.DAL.Interfaces;
using itlapr.DAL.Entities;
using itlapr.DAL.Context;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using System;

namespace itlapr.DAL.Repository
{
    public class SalesOrdersRepository : ISalesOrdersRepository
    {
        private readonly ItlaContext itlaContext;
        private readonly ILogger<SalesOrdersRepository> logger;

        public SalesOrdersRepository(ItlaContext itlaContext, 
                                     ILogger<SalesOrdersRepository> logger)
        {
            this.itlaContext = itlaContext;
            this.logger = logger;
        }
        public bool Exists(string name)
        {
            return this.itlaContext.SalesOrders.Any(st => st.shipname== name);
        }
        public List <SalesOrders> GetAll()
        {
            return this.itlaContext.SalesOrders.ToList();
        }
        public SalesOrders GetById(int orderid)
        {
            return this.itlaContext.SalesOrders.Find(orderid);
        }
        public void Remove(SalesOrders salesOrders)
        {
            try
            {
                SalesOrders salesOrdersToRemove = this.GetById(salesOrders.shipperid);

                salesOrdersToRemove.Deleted = true;
                salesOrdersToRemove.DeletedDate = DateTime.Now;
                salesOrdersToRemove.UserDeleted = salesOrders.UserDeleted;

                this.itlaContext.SalesOrders.Update(salesOrdersToRemove);
                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error removiendo el exportador", ex.ToString());
            }
        }
        public void Save(SalesOrders salesOrders)
        {
            try
            {
                SalesOrders salesToAdd = new SalesOrders()
                {
                    orderdate= salesOrders.orderdate,
                    requireddate= salesOrders.requireddate,
                    shippeddate= salesOrders.shippeddate,
                    freight = salesOrders.freight,
                    shipname = salesOrders.shipname,
                    shipadress = salesOrders.shipadress,
                    shipcity = salesOrders.shipcity,
                    shipregion = salesOrders.shipregion,
                    shipostalcode = salesOrders.shipostalcode,
                    shipconuntry = salesOrders.shipconuntry,
                    CreationDate = DateTime.Now,
                    CreationUser = salesOrders.CreationUser
                };

                this.itlaContext.SalesOrders.Add(salesToAdd);
                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error removiendo el exportador", ex.ToString());
                throw;

            }
        }
        public void Update(SalesOrders salesOrders)
        {
            try
            {
                SalesOrders salesToUpdate = this.GetById(salesOrders.shipperid);

                salesToUpdate.orderdate = salesOrders.orderdate;
                salesToUpdate.requireddate = salesOrders.requireddate;
                salesToUpdate.shippeddate = salesOrders.shippeddate;
                salesToUpdate.freight = salesOrders.freight;
                salesToUpdate.shipname = salesOrders.shipname;
                salesToUpdate.shipadress = salesOrders.shipadress;
                salesToUpdate.shipcity = salesOrders.shipcity;
                salesToUpdate.shipregion = salesOrders.shipregion;
                salesToUpdate.shipostalcode = salesOrders.shipostalcode;
                salesToUpdate.shipconuntry = salesOrders.shipconuntry;
                salesToUpdate.ModifyDate = DateTime.Now;
                salesToUpdate.UserMod = salesOrders.UserMod;

                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error removiendo el exportador");
                throw;
            }
        }
    }
}
