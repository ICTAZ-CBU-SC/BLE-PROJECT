using eRegister.DAL.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class AttendanceController : ControllerBase {
    private readonly ERegisterDbContext context;
    public AttendanceController(ERegisterDbContext context)
    {
        this.context = context;
    }   

    [HttpPost]
    public async Task<ActionResult> MarkAttendance(Attendance attendance){
        if (attendance == null)
            return NotFound(); // to be revised later

        context.Attendances.Add(attendance);
        await context.SaveChangesAsync(); // saves to db

        return CreatedAtAction("MarkAttendance", null);

    }
}