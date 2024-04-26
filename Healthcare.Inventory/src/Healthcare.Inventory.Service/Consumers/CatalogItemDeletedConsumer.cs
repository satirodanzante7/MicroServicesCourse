using Healthcare.Catalog.Contracts;
using Healthcare.Common;
using Healthcare.Inventory.Service.Entities;
using MassTransit;

namespace Healthcare.Inventory.Service.Consumers
{
    public class CatalogItemDeletedConsumer : IConsumer<CatalogItemDeleted>
    {
        private readonly IRepository<CatalogItem> repository;

        public CatalogItemDeletedConsumer(IRepository<CatalogItem> repository)
        {
            this.repository = repository;
        }

        public async Task Consume(ConsumeContext<CatalogItemDeleted> context)
        {
           var message = context.Message;

           var item = await repository.GetAsync(message.ItemId);

           if (item == null)
           {
                return;
           }
           
           await repository.RemoveAsync(message.ItemId);

        }
    }
}