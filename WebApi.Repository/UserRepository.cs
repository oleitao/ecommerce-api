﻿using Microsoft.EntityFrameworkCore;
using Model;
using WebApi.Contracts;
using WebApi.Entities.RequestFeatures;
using WebApi.Repository.Extensions;

namespace WebApi.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
            
        }

        #region Sync

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges).ToList();

        public User? GetUser(Guid userId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(userId), trackChanges)
            .SingleOrDefault();

        public void CreateUser(User user)
        {
            Create(user);
        }

        #endregion

        #region Async
        
        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<User?> GetUserAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(c => c.Id.Equals(userId.ToString()), trackChanges).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(UserParameters userParameters, bool trackChanges)
        {
            return await FindByCondition(c => c.Age >= userParameters.MinAge && c.Age <= userParameters.MaxAge, trackChanges)
                .FilterUsers(userParameters.MinAge, userParameters.MaxAge)
                .Search(userParameters.SearchTerm)
                .Sort(userParameters.OrderBy)
                .ToListAsync();
        }

        public async Task DeleteUser(User user)
        {
            Delete(user);

            await Task.CompletedTask;
        }

        public async Task<User?> FindByEmailAsync(string email, bool trackChanges)
        {
            return await FindByCondition(x => !string.IsNullOrEmpty(x.Email) && x.Email.Equals(email), trackChanges).FirstOrDefaultAsync();
        }

        public async Task<bool> ConfirmEmailAsync(User userEntity)
        {
            try
            {
                userEntity.EmailConfirmed = true;
                Update(userEntity);

                return true;
            }
            catch
            {
                return false;
            }
        }


        #endregion
    }
}
