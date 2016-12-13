using System;
namespace MyAppointments.Core.Models
{
	public class Appointment : BaseModel
	{
		public int Id { get; set; }
		public DateTime DateAndTime { get; set; }
		public HostPerson HostPerson { get; set; }
		public string Notes { get; set; }
	}
}