namespace MyAppointments.Core.Models
{
	public class HostPerson : BaseModel, IPerson
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public HostClass HostClass { get; set; }
		public string OpeningHours { get; set; }
		public string Address { get; set; }
		public CityCoordinates CityCoordinates { get; set;}
	}

	public enum HostClass
	{
		EarDoctor, 
		Audiologist,
		ADBSupportAgent
	}
}
