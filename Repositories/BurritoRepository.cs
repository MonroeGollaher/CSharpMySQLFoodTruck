using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using csharpfoodtruck.Models;

namespace csharpfoodtruck.Repositories
{
    public class BurritoRepository
    {
        private readonly IDbConnection _db;
        
        public BurritoRepository(IDbConnection db)
        {
            _db = db;
        }

    public IEnumerable<Burrito> Get()
    {
      string sql = "SELECT * FROM burritos";
      return _db.Query<Burrito>(sql);
    }

    public Burrito Create(Burrito burrito)
    {
      string sql = @"INSERT INTO burritos
      (title, description)
      VALUES
      (@Title, @Description);
      SELECT LAST_INSERT_ID();";
      burrito.Id = _db.ExecuteScalar<int>(sql, burrito);
      return burrito;
    }

    public bool Delete(int id)
    {
        string sql = "DELETE FROM burritos WHERE id = @Id LIMIT 1";
        int affectedRows = _db.Execute(sql, new { id });
        return affectedRows > 0;
    }
    public Burrito GetById(int id)
    {
        string sql = "SELECT * FROM burritos WHERE id=@Id";
        return _db.QueryFirstOrDefault<Burrito>(sql, new { id });
    }
  }
}