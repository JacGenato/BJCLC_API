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
    }
}
