
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Services;
using FluentValidation;

namespace API.Controllers
{
    /// <summary>
    /// Web API that handles all relevant HTTP commands.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "GetAll")]
        public ActionResult<IEnumerable<User>> Get()
        {
            try
            {
                var result = _userService.GetAllUsers();
                return Ok(result);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            try
            {
                var result = _userService.GetUser(id);
                if (result == null) { return NotFound(); }
                return Ok(result);
            }
            catch
            {
                return StatusCode(500);
            }

        }

        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            try
            {
                _userService.CreateUser(user);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] User user)
        {
            try
            {
                _userService.UpdateUser(user);
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (_userService.DeleteUser(id))
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                return NotFound();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}