using Basic.Application.DTOs;
using Basic.Application.UseCases;
using Basic.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Web.Controllers;
[ApiController]
[Route("[controller]")]//API Configuration

public class DataController(ShowUserData showUserData) :  ControllerBase
{
    [HttpGet("GetAllMenu")]
    public async Task<ActionResult<List<ShowData>>> GetAllMenu()
    {
        return Ok(await showUserData.GetAllMenus());
    }
}