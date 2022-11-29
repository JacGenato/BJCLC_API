using BJCLC_API.Models;
using BJCLC_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BJCLC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : Controller
    {
        public IPostRepository _iPostRepository;
        public PostController(IPostRepository iPostRepository)
        {
            _iPostRepository = iPostRepository;
        }


        [HttpGet("GetPosts")]
        public async Task<IEnumerable<Post>> Get()
        {
            return await _iPostRepository.Get();
        }

        [HttpGet("GetPostById")]
        public async Task<Post> GetPostById(int id)
        {
            return await _iPostRepository.GetById(id);
        }

        [HttpGet("Search")]
        public async Task<List<Post>> Search(string keyword)
        {
            return await _iPostRepository.Search(keyword);
        }

        [HttpPost("Create")]
        public async Task CreatePost(Post post)
        {
            await _iPostRepository.Create(post);
        }


        [HttpPut("UpdatePost")]
        public async Task<Post> UpdatePost(Post post)
        {
           return await _iPostRepository.Update(post);
        }

        [HttpDelete("DeletePost")]
        public async Task DeletePost(int id)
        {
            await _iPostRepository.Delete(id);
        }
    }
}
