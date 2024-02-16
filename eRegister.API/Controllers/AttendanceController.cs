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

     var dummmyAttendance = new Attendance(){
        SchoolCode= "SICT",
        DepartmentCode = "CS",
        ProgrammeCode = "42",
        CourseCode =  "CS350",
        Sin= 1234,
        DateAttended = "2024",
        IsPresent = 0
     };
        // if (attendance == null){
        //     Console.WriteLine("You are reaching here but it looks like the object null");
        //     return NotFound("You are reaching here but it looks like the object null"); // to be revised later
        // }

        context.Attendances.Add(dummmyAttendance);
        await context.SaveChangesAsync(); // saves to db

        return CreatedAtAction("MarkAttendance", null);

    }
}