using Model;
using System.Linq.Dynamic.Core;
using WebApi.Repository.Extensions.Utility;

namespace WebApi.Repository.Extensions
{
    public static class RepositoryUserExtensions
    {
        public static IQueryable<User> FilterUsers(this IQueryable<User> users, uint minAge, uint maxAge) =>
            users.Where(e => (e.Age >= minAge && e.Age <= maxAge));

        public static IQueryable<User> Search(this IQueryable<User> users, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return users;


            var lowCaseTerm = searchTerm.Trim().ToLower();

            return users.Where(e => e.FullName.ToLower().Contains(lowCaseTerm));
        }


        public static IQueryable<User> Sort(this IQueryable<User> users, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString)) 
                return users.OrderBy(e => e.FullName); 
            
            var orderQuery = OrderQueryBuilder.CreateOrderQuery<User>(orderByQueryString); 
            
            if (string.IsNullOrWhiteSpace(orderQuery)) 
                return users.OrderBy(e => e.FullName); 
            
            return users.OrderBy(orderQuery);
        }
    }
}
