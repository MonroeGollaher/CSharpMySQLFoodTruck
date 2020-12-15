using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using csharpfoodtruck.Models;

namespace csharpfoodtruck.Repositories
{
    public class BurgerRepository
    {
        private readonly IDbConnection _db;

        public BurgerRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Burger> GetAll()
        {
            string sql = "SELECT * FROM burgers";
            return _db.Query<Burger>(sql);
        }
  }
}