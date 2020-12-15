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
    }
}