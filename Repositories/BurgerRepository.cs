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

        public Burger GetById(int id)
        {
            string sql = "SELECT * FROM burgers WHERE id=@Id";
            return _db.QueryFirstOrDefault<Burger>(sql, new { id });
        }

        public Burger Create(Burger burger)
        {
            string sql = @"INSERT INTO burgers
            (title, description)
            VALUES
            (@Title, @Description);
            SELECT LAST_INSERT_ID();";
            burger.Id = _db.ExecuteScalar<int>(sql, burger);
            return burger;
        }

        public bool Delete(int id)
        {
            string sql = "DELETE FROM burgers WHERE id = @Id LIMIT 1";
            int affectedRows = _db.Execute(sql, new { id });
            return affectedRows > 0;
        }
  }
}