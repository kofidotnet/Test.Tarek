using Microsoft.AspNetCore.Mvc;
using Test.Tarek.Logic.Services;
using Test.Tarek.Models;
using Test.Tarek.Models.Entities;

namespace Test.Tarek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<BaseResponse<List<UserModel>>>> GetUsers()
        {
            var users = new List<UserModel>();
            try
            {
                users = await userService.GetUsers();
            }
            catch (Exception ex)
            {
                BadRequest(new BaseResponse<List<UserModel>> { ErrorMessage = ex.Message, Success = false });
            }
            return Ok(new BaseResponse<List<UserModel>> { Data = users, Success = true });
        }
    }
}
