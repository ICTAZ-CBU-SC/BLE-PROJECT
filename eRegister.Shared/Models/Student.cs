namespace eRegister.Shared;

using System.ComponentModel.DataAnnotations;

public class Student{
    [Key]
    [Required]
    public int SIN { get; set; }
    [Required]
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    [Required]
    public string Lastname { get; set; }
    public string ProgCode { get; set; }
    public string ProgDescription { get; set; }
    public Guid DeviceAddress { get; set; }
}