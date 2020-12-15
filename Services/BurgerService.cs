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

    public Burger GetById(int id)
    {
      Burger foundBurger = _repo.GetById(id);
      if(foundBurger == null)
      {
        throw new Exception("There is no burger with that id");
      }
      return foundBurger;
    }
    public Burger Create(Burger burger)
    {
      return _repo.Create(burger);
    }

    public string Delete(int id)
    {
      if(_repo.Delete(id))
      {
        return "You have deleted the burger";
      }
      throw new Exception("That did not work");
    }
  }
}