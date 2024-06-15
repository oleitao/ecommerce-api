using Model;
using System.Linq.Dynamic.Core;
using WebApi.Repository.Extensions.Utility;

namespace WebApi.Repository.Extensions
{
    public static class RepositoryProductExtensions
    {
        public static IQueryable<Product> Search(this IQueryable<Product> products, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return products;


            var lowCaseTerm = searchTerm.Trim().ToLower();

            return products.Where(e => e.Name.ToLower().Contains(lowCaseTerm));
        }

        public static IQueryable<Product> Sort(this IQueryable<Product> products, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return products.OrderBy(e => e.Name);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Product>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
                return products.OrderBy(e => e.Name);

            return products.OrderBy(orderQuery);
        }
    }
}
