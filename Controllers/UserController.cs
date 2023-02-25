using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstApi.models;
using Microsoft.AspNetCore.Mvc;

namespace firstApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {
    [HttpGet]
    public ActionResult<List<UsersModel>> GetAllUsers()
    {
      return Ok();
    }
  }
}