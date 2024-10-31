using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace WebApi.Repository.Configuration
{
    internal class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder) 
        {
            builder.HasData
            (
                new OrderStatus
                {
                    Id=Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208512"),
                    Status = "Requested"
                },
                new OrderStatus
                {
                    Id = Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208513"),
                    Status = "In preparation..."
                },
                new OrderStatus
                {
                    Id = Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208514"),
                    Status = "On going..."
                },
                new OrderStatus
                {
                    Id = Guid.Parse("6E27B4B8-E66C-450A-BF41-58344B208515"),
                    Status = "Delivered!"
                }
            );
        }    
    }
}
