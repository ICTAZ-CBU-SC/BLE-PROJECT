using eRegister.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using eRegister.Shared;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase {
    private readonly ERegisterDbContext context;
    public StudentController(ERegisterDbContext context)
    {
        this.context = context;
    }   

    [HttpPost]
    [Route("RegisterStudent")]
    public async Task<ActionResult> MarkAttendance([FromBody] Student student){

        if (student == null){
            return NotFound("Student object cannot be null"); // to be revised later
        }

        context.Students.Add(student);
        await context.SaveChangesAsync(); // saves to db

        return CreatedAtAction("Student", null);

    }
}