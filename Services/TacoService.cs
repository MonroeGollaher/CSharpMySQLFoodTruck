using System;
using System.Collections.Generic;
using csharpfoodtruck.Models;
using csharpfoodtruck.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace csharpfoodtruck.Services
{
  public class TacoService
  {
    private readonly TacoRepository _repo;

    public TacoService(TacoRepository repo)
    {
        _repo = repo;
    }
    public IEnumerable<Taco> Get()
    {
      return _repo.Get();
    }

    public Taco Create(Taco taco)
    {
        return _repo.Create(taco);
    }
    public string Delete(int id)
    {
        if(_repo.Delete(id))
        {
            return "You have deleted the taco";
        }
        throw new Exception("You weren't able to delete the taco");
    }

    public Taco GetById(int id)
    {
        Taco foundTaco  = _repo.GetById(id);
        if(foundTaco == null)
        {
            throw new Exception("There is no taco with that id");
        }
        return foundTaco;
    }
  }
}