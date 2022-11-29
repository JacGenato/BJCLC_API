using BJCLC_API.Models;
using BJCLC_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BJCLC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public IUserRepository _iUserRpository;
        public UserController(IUserRepository iUserRpository)
        {
            _iUserRpository = iUserRpository;
        }

        [HttpGet("GetUsers")]
        public async Task<IEnumerable<User>> Get()
        {
            return await _iUserRpository.Get();
        }

        [HttpGet("SearchUsers")]
        public async Task<IEnumerable<User>> Search(string keyword)
        {
            if (keyword == null) return null;
            return  await _iUserRpository.Search(keyword);
           
        }

        [HttpPost("Create")]
        public async Task Create(User user)
        {
            await _iUserRpository.Create(user);
        }

        [HttpPut("UpdateUser")]
        public async Task Update(User user)
        {
            await _iUserRpository.Update(user);
        }

        [HttpDelete("DeleteUser")]
        public async Task Delete(int id)
        {
            await _iUserRpository.Delete(id);
        }
    }
}
