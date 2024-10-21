namespace InventoryManagementAPI.Models
{
  public class Item
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
  }
}