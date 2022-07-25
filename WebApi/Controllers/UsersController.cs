using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IAppRepository _appRepository;

        public UsersController(IAppRepository appRepository)
        {
               _appRepository = appRepository;
        }

        [HttpGet]
        [Route("get")]
        public ActionResult GetUsers()
        {
            var users = _appRepository.GetList();
            return Ok(users);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]User user)
        {
            _appRepository.Add(user);
            _appRepository.SaveAll();
            return Ok(user);
        }
    }
}
