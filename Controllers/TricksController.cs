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

    [HttpGet]
    public string GetTrick() {
      var tricks = this.tricksService.GetTricks();
      int trickIndex = this.generator.Next(0, tricks.Length);
      return tricks[trickIndex];
    }
  }
}
