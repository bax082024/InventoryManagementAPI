using System.Collections.Generic;
using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Services
{
  public interface IInventoryService
  {
    IEnumerable<Item> GetItems();
    Item GetItemById(int id);
    void AddItem(Item newItem);
    void UpdateItem(Item UpdatedItem);
    void DeleteItem(int id);
  }
}