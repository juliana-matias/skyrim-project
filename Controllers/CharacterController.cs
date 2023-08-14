global using skyrim_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace skyrim_project.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private static Character nord = new Character();

    [HttpGet]
    public ActionResult<Character> Get()
    {
        return Ok(nord);
    }
}
}