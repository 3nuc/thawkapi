using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using thawkapi.Services;

namespace thawkapi.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class TricksController : ControllerBase
  {
    private Random generator = new Random();
    private TricksService tricksService = new TricksService();

    [HttpGet("random")]
    public string GetRandomTrick() {
      return tricksService.GetRandomTrick();
    }
    [HttpGet("one")]
    public string[] GetAllTricks() {
      return tricksService.GetAllTricks();
    }
  }
}
