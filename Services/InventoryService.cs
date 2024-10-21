using System.Collections.Generic;
using System.Linq;
using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Services
{
  public class InventoryService : IInventoryService
  {
    private readonly List<Item> _items;

    public InventoryService()
    {
      _items = new List<Item>
      {
        new Item {Id = 1, Name = "random1", Quantity = 5, Price = 45M, Description = "Random1"},
        new Item {Id = 2, Name = "random2", Quantity = 25, Price = 147M, Description = "Random2"}
      };
    }


  }



}