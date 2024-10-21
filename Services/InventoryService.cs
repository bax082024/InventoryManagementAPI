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


    public IEnumerable<Item> GetItems() => _items;

    public Item GetItemById(int id) => _items.FirstOrDefault(item => item.Id == id);
        public void Additem(Item newItem)
        {
            newItem.Id = _items.Max(i => i.Id) + 1;
            _items.Add(newItem);
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item UpdatedItem)
        {
            throw new NotImplementedException();
        }
    }



}