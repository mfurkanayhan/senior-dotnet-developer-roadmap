using eHospitalServer.Entities.Enums;

namespace eHospitalServer.Entities.Models;

public sealed class DoctorDetail
{
    public DoctorDetail() 
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public Speciality Specialty { get; set; } = Speciality.Emergency;
    public List<string> WorkingDays { get; set; } = new();
    public decimal AppointmentPrice { get; set; }
    public string SpecialtyName => Specialty.ToString();
}