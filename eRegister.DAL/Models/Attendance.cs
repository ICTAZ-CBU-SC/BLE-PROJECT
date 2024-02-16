using System;
using System.Collections.Generic;

namespace eRegister.DAL.Models;

public partial class Attendance
{
    public int Id { get; set; }

    public string SchoolCode { get; set; } = null!;

    public string DepartmentCode { get; set; } = null!;

    public string ProgrammeCode { get; set; } = null!;

    public string CourseCode { get; set; } = null!;

    public int Sin { get; set; }

    public string DateAttended { get; set; } = null!;

    public int? IsPresent { get; set; }
}
