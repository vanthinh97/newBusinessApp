using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newBusinessApp.Data;
using newBusinessApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace newBusinessApp.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() => await _context.Users.ToListAsync();

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUserById(int id) => _context.Users.Find(id);
    }
}
