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
        Task<Post> Update(Post post);
        Task Delete(int id);

    }
    public class PostRepository : IPostRepository
    {

        private readonly DataContext dataContext;
        public PostRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task Create(Post post)
        {
            await dataContext.Posts.AddAsync(post);
            await dataContext.SaveChangesAsync();
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

        public async Task<Post> Update(Post post)
        {
            var postUpdate = await dataContext.Posts.FirstOrDefaultAsync(c => c.Id == post.Id);

            postUpdate.Title = post.Title;
            postUpdate.Description = post.Description;
            postUpdate.Content = post.Content;
            postUpdate.CoverImage = post.CoverImage;

            dataContext.Posts.Update(postUpdate);

            await dataContext.SaveChangesAsync();

            return postUpdate;
        }

        public async Task Delete(int id)
        {
            var post = await dataContext.Posts.FirstOrDefaultAsync(c => c.Id == id);
            dataContext.Posts.Remove(post); 
            await dataContext.SaveChangesAsync();
        }

    }
}
