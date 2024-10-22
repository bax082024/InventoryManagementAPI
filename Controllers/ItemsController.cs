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

    [HttpGet("{id}")]
    public ActionResult<Item> GetItem(int id)
    {
      var item = _inventoryService.GetItemById(id);
      if (item == null)
      {
        return NotFound();
      }
      return Ok(item);
    }

    [HttpPost]
    public ActionResult AddItem([FromBody] Item newItem)
    {
      _inventoryService.AddItem(newItem);
    }

  }

}
