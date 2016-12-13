using MyAppointments.Core.Models;
using System.Collections.Generic;
using System;

namespace MyAppointments.Core.Repositories
{
	public static class MockRepository
	{
		#region Mock Appointments
		public static readonly List<Appointment> Appointments = new List<Appointment>
		{
					new Appointment {
										Id = 1,
										HostPerson = new HostPerson { Id = 1, Name = "Dr. Occhilupo"},
										DateAndTime = DateTime.Today,
										Notes = "No further notes."
									  },
					new Appointment {
										Id = 2,
										HostPerson = new HostPerson { Id = 2, Name = "Dr. Slater" },
										DateAndTime = DateTime.Parse("12/10/2016"),
										Notes = "No further notes."
									  },
					new Appointment {
										Id = 3,
										HostPerson = new HostPerson { Id = 3, Name = "Dr. Curren" },
										DateAndTime = DateTime.Parse("12/16/2016"),
										Notes = "No further notes."
									  },
					new Appointment {
										Id = 4,
										HostPerson = new HostPerson { Id = 4, Name = "Dr. Carrol" },
										DateAndTime = DateTime.Parse("03/03/2017"),
										Notes = "No further notes."
									  },
					new Appointment {
										Id = 5,
										HostPerson = new HostPerson { Id = 5, Name = "Mr. Jackson" },
										DateAndTime = DateTime.Now.AddDays(3),
										Notes = "No further notes."
									  },
					new Appointment {
										Id = 6,
										HostPerson = new HostPerson { Id = 6, Name = "Mr. Dylan" },
										DateAndTime = DateTime.Now.AddDays(7),
										Notes = "No further notes."
									  }
		};
		#endregion

		#region City Coordinates
		public static readonly List<CityCoordinates> CityCoordinatesList = new List<CityCoordinates>
		{
			new CityCoordinates { Id = 1, Name = "Berlin", Latitude = 52.520, Longitude = 13.4050 },
			new CityCoordinates { Id = 2, Name = "Los Angeles",  Latitude = 33.93, Longitude = -118.40 },
			new CityCoordinates { Id = 3, Name = "London",  Latitude = 51.509, Longitude = -0.1 },
			new CityCoordinates { Id = 4, Name = "Paris", Latitude = 48.857, Longitude = 2.351 },
			new CityCoordinates { Id = 5, Name = "New York", Latitude = 40.77, Longitude = -73.98 },
			new CityCoordinates { Id = 6, Name = "Florianopolis", Latitude = -27.5954, Longitude = -48.5480 },
			new CityCoordinates { Id = 7, Name = "Gary", Latitude = 41.5934, Longitude = -87.3464 },
			new CityCoordinates { Id = 8, Name = "Duluth", Latitude = 46.7867, Longitude = -92.1005 }
		};
		#endregion

		#region People
		public static readonly List<IPerson> People = new List<IPerson>
		{
					new HostPerson {
									Id = 1,
									Name = "Dr. Occhilupo",
									HostClass = HostClass.Audiologist,
									Address = "Avenue 1 - Berlin, GER",
									CityCoordinates = CityCoordinatesList.Find(x => x.Name == "Berlin"),
									OpeningHours = "Mon-Fri\n08:00 - 17:00\n\nSat\n08:00 - 12:00"
									},
					new HostPerson {
									Id = 2,
									Name = "Dr. Slater",
									HostClass = HostClass.EarDoctor,
									Address = "Avenue 2 - Paris, FRA",
									CityCoordinates = CityCoordinatesList.Find(x => x.Name == "Paris"),
									OpeningHours = "Mon-Fri\n09:00 - 17:00"
								 },
					new HostPerson {
									Id = 3,
									Name = "Dr. Curren",
									HostClass = HostClass.EarDoctor,
									Address = "Avenue 3 - London, UK",
									CityCoordinates = CityCoordinatesList.Find(x => x.Name == "London"),
									OpeningHours = "Mon-Fri\n08:30 - 17:00"
								 },
					new HostPerson {
									Id = 4,
									Name = "Dr. Carrol",
									HostClass = HostClass.Audiologist,
									Address = "Avenue 4 - Florianopolis, BRA",
									CityCoordinates = CityCoordinatesList.Find(x => x.Name == "Florianopolis"),
									OpeningHours = "Mon-Fri\n09:30 - 17:00"
								 },
					new HostPerson {
									Id = 5,
									Name = "Mr. Jackson",
									HostClass = HostClass.ADBSupportAgent,
									Address = "Street 5 - Gary, USA",
									CityCoordinates = CityCoordinatesList.Find(x => x.Name == "Gary"),
									OpeningHours = "Mon-Fri\n09:30 - 17:00"
								 },
					new HostPerson {
									Id = 6,
									Name = "Mr. Dylan",
									HostClass = HostClass.ADBSupportAgent,
									Address = "Street 6 - Duluth, USA",
									CityCoordinates = CityCoordinatesList.Find(x => x.Name == "Duluth"),
									OpeningHours = "Mon-Fri\n09:30 - 17:00"
								 }
		};
		#endregion
	}
}
