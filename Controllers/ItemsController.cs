using Microsoft.AspNetCore.Mvc;
using InventoryManagementAPI.Services;
using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ItemsController : ControllerBase
  {
    private readonly IInventoryService _inventoryService;

    public ItemsController(IInventoryService inventoryService)
    {
      _inventoryService = inventoryService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Item>> GetItems()
    {
      return Ok(_inventoryService.GetItems());
    }

  }

}
