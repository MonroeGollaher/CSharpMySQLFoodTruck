using System;
using System.Collections.Generic;
using csharpfoodtruck.Models;
using csharpfoodtruck.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace csharpfoodtruck.Services
{
  public class BurritoService
  {
      private readonly BurritoRepository _repo;

      public BurritoService(BurritoRepository repo)
      {
          _repo = repo;
      }

    public IEnumerable<Burrito> Get()
    {
        return _repo.Get();
    }

    public Burrito Create(Burrito burrito)
    {
        return _repo.Create(burrito);
    }

    public string Delete(int id)
    {
        if(_repo.Delete(id))
        {
            return "You have deleted the burrito"; 
        }
        throw new Exception("Yeah, no, that didn't work.");
    }

    public Burrito GetById(int id)
    {
       Burrito foundBurrito = _repo.GetById(id);
       if(foundBurrito == null)
       {
            throw new Exception("There is no burrito with that id");
       }
       return foundBurrito;
    }
  }
}