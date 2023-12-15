using BANKAPI.Data.Model;
using BANKAPI.Data.ViewModel;
using BANKAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BANKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetAll());
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            return Ok(await _userService.GetById(id));
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] UserViewModel data)
        {
            _userService.Create(data);

            return Ok("User Created Successfully");
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update([FromBody] User data)
        {
            _userService.Update(data);

            return Ok("Successful Update");
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            _userService.Delete(id);

            return Ok("Successful Removal");
        }
    }
}
