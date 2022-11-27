using BJCLC_API.Data;
using BJCLC_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BJCLC_API.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> Get();
        Task<Post> GetById(int id);
        Task<List<Post>> Search(string searchKey);
        Task Create(Post post);
        Task Update(Post post);

    }
    public class PostRepository : IPostRepository
    {

        private readonly DataContext dataContext;
        public PostRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public Task Create(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> Get()
        {
            return await dataContext.Posts.ToListAsync();
        }

        public async Task<Post> GetById(int id)
        {
            return await dataContext.Posts.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<List<Post>> Search(string searchKey)
        {
            return dataContext.Posts.Where(c => c.Title.ToLower().Contains(searchKey.ToLower())).ToListAsync();
        }

        public Task Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
