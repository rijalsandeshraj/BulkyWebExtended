﻿using BulkyWeb.Models.Models;

namespace BulkyWeb.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}