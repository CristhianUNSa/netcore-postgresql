

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly MyWebApiContext _context;

        public UsersController(MyWebApiContext context)
        {
            _context = context;
        }
        public IActionResult Get()
        {
            return Json(_context.Users.Select(u => u.Name).ToList());
        }
    }
}