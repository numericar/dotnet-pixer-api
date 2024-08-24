﻿using PixerAPI.Contexts;
using PixerAPI.Models;
using PixerAPI.Repositories.Interfaces;

namespace PixerAPI.Repositories
{
    public class ProductArgrementRepository : Repository<ProductArgrement>, IProductArgrementRepository
    {
        public ProductArgrementRepository(MySQLDbContext mySQLDbContext) : base(mySQLDbContext)
        {
        }
    }
}