using DbContextLibrary;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;
        }

        public async Task AddOrderAsync(Guid userId, OrderViewModel order)
        {
            var newOrder = new Order
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.UtcNow,
                Status = OrderStatus.Pending,
                UserId = userId,
                DeliveryAddress = new DeliveryAddress
                {
                    Id = Guid.NewGuid(),
                    Street = order.FormData.Street,
                    Apartment = order.FormData.Apartment,
                    Entrance = order.FormData.Entrance,
                    Floor = order.FormData.Floor,
                    Doorphone = order.FormData.Doorphone
                },
                Comment = order.FormData.Comment
            };

            newOrder.Details = order.Products.Select(detail => new OrderDetail
            {
                Id = Guid.NewGuid(),
                OrderId = newOrder.Id,
                ProductId = detail.ProductId,
                Quantity = detail.Quantity,
                Amount = detail.Amount
            }).ToList();

            _context.Orders.Add(newOrder);
            await _context.SaveChangesAsync();
        }
    }
}
