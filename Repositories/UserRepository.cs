using BJCLC_API.Data;
using BJCLC_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BJCLC_API.Repositories
{
    public interface IUserRepository
    {
        Task<User[]> Get();
        Task<User[]> Search(string searchKey);
        Task Create(User user);
        Task Update(User user);

    }
    public class UserRepository : IUserRepository
    {

        private readonly DataContext dataContext;
        public UserRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task Create(User user)
        {
            await dataContext.AddAsync(user);
            await dataContext.SaveChangesAsync();
        }

        public Task<User[]> Get()
        {
            return dataContext.Users.ToArrayAsync();
        }

        public Task<User[]> Search(string searchKey)
        {
       
            return dataContext.Users.Where(c => c.Name.ToLower().Contains(searchKey.ToLower())).ToArrayAsync();
         
        }

        public async Task Update(User user)
        {
            var existingUser = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == user.Id);

            if (existingUser == null)
                return;

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.MobileNumber = user.MobileNumber;

            await dataContext.SaveChangesAsync();
        }
    }
}
