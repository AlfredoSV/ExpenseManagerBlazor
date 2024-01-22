using AutoMapper;
using ExpenseManagerBlazor.Server.Models;
using ExpenseManagerBlazor.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagerBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMapper mapper;

        public LoginController(IMapper mapper)
        {
            this.mapper = mapper;
        }
        [HttpPost]
        public IActionResult Login([FromBody] UserModel dtoUser)
        {
            try
            {

                
                return Ok(dtoUser);
            }
            catch (Exception)
            {

                throw;
            }

           
        }

        [HttpGet("tests")]
        public IActionResult TestMapper() {

            var userModel = new UserModel();
            userModel.Email = "alfredosv97@gmail.com";
            userModel.Password= "ddpassword";

            UserDto userDto = mapper.Map<UserDto>(userModel);

            return Ok(userDto);
        }

    }

    

}
