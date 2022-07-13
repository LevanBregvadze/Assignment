using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task7.Models;

namespace Task7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Task7Controller : ControllerBase
    {
        private readonly ApiDbContext _context;

        public Task7Controller(ApiDbContext context)
        {
            _context = context;
        }


        [HttpGet("GetAllTeachersByStudent/{StudentName}")]
        public ActionResult<IEnumerable<Teacher>> GetTeachers(string StudentName)
        {
            var pupilbyName = _context.Pupils.Where(x => x.firstName == StudentName).SingleOrDefault();
            if (pupilbyName  == null)
            {
                return BadRequest(new { message = "Pupil not found" });
            }
            var y = _context.Teacher_Pupils.Include(x => x.Pupil).Where(entry => entry.PupilId == pupilbyName.Id)
                .Select(entry => entry.Teacher).ToList();

            return Ok(y);

        }




    }
}
