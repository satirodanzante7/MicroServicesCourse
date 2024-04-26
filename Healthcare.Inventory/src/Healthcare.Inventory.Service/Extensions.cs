using Healthcare.Inventory.Service.Dtos;
using Healthcare.Inventory.Service.Entities;

namespace Healthcare.Inventory.Service
{
    public static class Extensions
    {
        public static InventoryItemDto AsDto(this InventoryItem item, string name, string description)
        {
            return new InventoryItemDto(item.CatalogItemId, item.Quantity, name, description, item.AcquiredDate);
        }
    }
}