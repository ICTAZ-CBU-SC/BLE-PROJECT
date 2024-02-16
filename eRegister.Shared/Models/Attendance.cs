using System.ComponentModel.DataAnnotations;

public class Attendance
{
    [Required]
    public string SchoolCode { get; set; }
    [Required]
    public string DepartmentCode { get; set; }
    [Required]
    public string ProgramCode { get; set; }
    [Required]
    public string CourseCode { get; set; }
    [Required]
    public int SIN { get; set; }
    [Required]
    public DateTime DateAttended { get; set; } = DateTime.Now;
    public bool IsPresent { get; set; }
}