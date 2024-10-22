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

        new Item {Id = 1, Name = "Post it 10pk", Quantity = 10, Price = 75M, Description = "Post it pads 10 pack"},
        new Item {Id = 2, Name = "Pen Uniball 12pcs", Quantity = 12, Price = 165M, Description = "uniball 207 Needle Retractable Gel Pens, Medium Point, 0.7mm, Blue Ink, Dozen"}
        new Item {Id = 1, Name = "Sharpie Retractable S-Gel", Quantity = 12, Price = 180M, Description = "Sharpie S-Gel Retractable Gel Pen, Medium Point, Black Ink, Dozen"},
        new Item {Id = 1, Name = "Zebra Z-Grip Retractable Ballpoint", Quantity = 24, Price = 110M, Description = "Zebra Z-Grip Retractable Ballpoint Pen, Medium Point, 1.0mm, Black Ink, 24 Pack"},
        
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
        var item = GetItemById(id);
        if (item != null)
        {
          _items.Remove(item);
        }
    }

    public void UpdateItem(Item UpdatedItem)
    {
      existingItem.Name = updatedItem.Name;
      existingItem.Quantity = updatedItem.Quantity;
      existingItem.Price = updatedItem.Price;
      existingItem.Description = updatedItem.Description;

    }
  }



}