using Basic.Application.DTOs;
using Basic.Application.UseCases;
using Basic.Core.Entities;
using Basic.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Web.Controllers;

[ApiController]
[Route("[controller]")] //API Configuration
public class DataController : ControllerBase
{
    private readonly ShowUserData _showUserData;
    private readonly AddToMenu _addToMenu;
    private readonly ChangeMenu _changeMenu;
    private readonly DeleteMenu _deleteMenu;

    public DataController(ShowUserData showUserData, AddToMenu addToMenu, ChangeMenu changeMenu, DeleteMenu deleteMenu)
    {
        _showUserData = showUserData;
        _addToMenu = addToMenu;
        _changeMenu = changeMenu;
        _deleteMenu = deleteMenu;
    }

    [HttpGet("GetAllMenu")]
    [Authorize]
    public async Task<ActionResult<List<ShowData>>> GetAllMenu()
    {
        var menus = await _showUserData.GetAllMenus();
        return Ok(menus);
    }

    [HttpPost("AddNewMenuItem")]
    public async Task<ActionResult<ShowData>> AddToMenu(ShowDataRequest showDataRequest, CancellationToken cancellationToken)
    {
        var response = await _addToMenu.CreateNewMenuItem(showDataRequest, cancellationToken);
        return Ok(response);
    }

    [HttpPut("UpdateDataBase")]
    public async Task<ActionResult<ShowData>> ChangeMenu(ShowData showData, CancellationToken cancellationToken)
    {
        var response = await _changeMenu.UpdateMenu(showData , cancellationToken);
        return Ok(response);
    }
    [HttpDelete("DeleteMenu")]
    public async Task<ActionResult> DeleteMenu(ShowDeleteData showDeleteData)
    {
        await _deleteMenu.DeleteRecord(showDeleteData.Id);
        return Ok();
    }
}