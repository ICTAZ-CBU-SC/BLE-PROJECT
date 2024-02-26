using eRegister.DAL.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AttendanceController : ControllerBase {
    private readonly ERegisterDbContext context;
    public AttendanceController(ERegisterDbContext context)
    {
        this.context = context;
    }   

    [HttpPost]
    [Route("MarkAttendance")]
    public async Task<ActionResult> MarkAttendance([FromBody] Attendance attendance){

        if (attendance == null){
            return NotFound("You are reaching here but it looks like the object null"); // to be revised later
        }

        context.Attendances.Add(attendance);
        await context.SaveChangesAsync(); // saves to db

        return CreatedAtAction("MarkAttendance", null);

    }
}