﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularLab.Models
{
    public class ProductEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public DateTime CreateDate { get; set; }

        public bool OnSaled { get; set; }

        public static IQueryable<ProductEntity> GetDatas()
        {
            List<ProductEntity> data = new List<ProductEntity>();
            data.Add(new ProductEntity { CategoryId = 1, ProductId = 1, ProductName = "iPhone3", Price = 5000, Qty = 5, CreateDate = new DateTime(2009, 1, 1) });
            data.Add(new ProductEntity { CategoryId = 1, ProductId = 2, ProductName = "iPhone4", Price = 10000, Qty = 6, CreateDate = new DateTime(2010, 3, 1) });
            data.Add(new ProductEntity { CategoryId = 1, ProductId = 3, ProductName = "iPhone4s", Price = 15000, Qty = 15, CreateDate = new DateTime(2011, 4, 1) });
            data.Add(new ProductEntity { CategoryId = 1, ProductId = 4, ProductName = "iPhone5", Price = 20000, Qty = 25, CreateDate = new DateTime(2012, 5, 1), OnSaled = true });
            data.Add(new ProductEntity { CategoryId = 1, ProductId = 5, ProductName = "iPhone5s", Price = 25000, Qty = 5, CreateDate = new DateTime(2013, 6, 8), OnSaled = true });

            data.Add(new ProductEntity { CategoryId = 2, ProductId = 6, ProductName = "Diamond", Price = 5000, Qty = 5, CreateDate = new DateTime(2009, 1, 1) });
            data.Add(new ProductEntity { CategoryId = 2, ProductId = 7, ProductName = "Titan", Price = 6000, Qty = 25, CreateDate = new DateTime(2010, 1, 13) });
            data.Add(new ProductEntity { CategoryId = 2, ProductId = 8, ProductName = "One", Price = 7000, Qty = 35, CreateDate = new DateTime(2011, 3, 12) });
            data.Add(new ProductEntity { CategoryId = 2, ProductId = 9, ProductName = "New One", Price = 15000, Qty = 45, CreateDate = new DateTime(2012, 11, 1), OnSaled = true });
            data.Add(new ProductEntity { CategoryId = 2, ProductId = 10, ProductName = "Flyer", Price = 3000, Qty = 55, CreateDate = new DateTime(2013, 1, 1), OnSaled = true });

            data.Add(new ProductEntity { CategoryId = 3, ProductId = 11, ProductName = "Lumia610", Price = 5000, Qty = 5, CreateDate = new DateTime(2009, 1, 1) });
            data.Add(new ProductEntity { CategoryId = 3, ProductId = 12, ProductName = "Lumia710", Price = 7000, Qty = 45, CreateDate = new DateTime(2010, 12, 1) });
            data.Add(new ProductEntity { CategoryId = 3, ProductId = 13, ProductName = "Lumia810", Price = 8000, Qty = 35, CreateDate = new DateTime(2011, 11, 30) });
            data.Add(new ProductEntity { CategoryId = 3, ProductId = 14, ProductName = "Lumia920", Price = 13000, Qty = 25, CreateDate = new DateTime(2012, 10, 12) });
            data.Add(new ProductEntity { CategoryId = 3, ProductId = 15, ProductName = "Lumia1500", Price = 18000, Qty = 5, CreateDate = new DateTime(2013, 9, 12), OnSaled = true });

            return data.AsQueryable();
        }
    }
}