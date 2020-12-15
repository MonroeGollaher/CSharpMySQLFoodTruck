using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using csharpfoodtruck.Models;

namespace csharpfoodtruck.Repositories
{
    public class TacoRepository
    {
        private readonly IDbConnection _db;
        
        public TacoRepository(IDbConnection db)
        {
            _db = db;
        }

    public IEnumerable<Taco> Get()
    {
      string sql = "SELECT * FROM tacos";
      return _db.Query<Taco>(sql);
    }

    public Taco Create(Taco taco)
    {
        string sql = @"INSERT INTO tacos
        (title, description)
        VALUES
        (@Title, @Description);
        SELECT LAST_INSERT_ID();";
        taco.Id = _db.ExecuteScalar<int>(sql, taco);
        return taco;
    }

    public bool Delete(int id)
    {
        string sql = "DELETE FROM tacos WHERE id = @Id LIMIT 1";
        int affectedRows = _db.Execute(sql, new { id });
        return affectedRows > 0; 
    }

    public Taco GetById(int id)
    {
        string sql = "SELECT * FROM tacos WHERE id=@Id";
        return _db.QueryFirstOrDefault<Taco>(sql, new { id });
    }
  }
}