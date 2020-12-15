using System;
using System.Collections.Generic;
using csharpfoodtruck.Models;
using csharpfoodtruck.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace csharpfoodtruck.Services
{
  public class BurgerService
  {
    private readonly BurgerRepository _repo;

    public BurgerService(BurgerRepository repo)
    {
        _repo = repo;
    }
    public IEnumerable<Burger> GetAll()
    {
      return _repo.GetAll();
    }
  }
}