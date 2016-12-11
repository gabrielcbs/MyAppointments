using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAppointments.Core.Contracts.Repositories;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Repositories
{
	public class HostPersonRepository : BaseRepository, IHostPersonRepository
	{
		public async Task<IPerson> GetHostPersonDetails(int appointmentId)
		{
			return await Task.FromResult(People.FirstOrDefault(x => x.Id == appointmentId));
		}

		public async Task<IEnumerable<IPerson>> SearchHostPerson(string name)
		{
			return await Task.FromResult(People.Where(x => x.Name == name));
		}

		#region Mock Appointments
		static readonly List<IPerson> People = new List<IPerson>
		{
					new HostPerson {
									Id = 1,
									Name = "Dr. Occhilupo",
									HostClass = HostClass.Audiologist,
									Address = "Avenue 1 - Berlin, GER",
									OpeningHours = "Mon-Fri\n08:00 - 17:00\n\nSat\n08:00 - 12:00"
									},
					new HostPerson {
									Id = 2,
									Name = "Dr. Slater",
									HostClass = HostClass.EarDoctor,
									Address = "Avenue 2 - Paris, FRA",
									OpeningHours = "Mon-Fri\n09:00 - 17:00"
								 },
					new HostPerson {
									Id = 3,
									Name = "Dr. Curren",
									HostClass = HostClass.EarDoctor,
									Address = "Avenue 3 - Milan, ITA",
									OpeningHours = "Mon-Fri\n08:30 - 17:00"
								 },
					new HostPerson {
									Id = 4,
									Name = "Dr. Carrol",
									HostClass = HostClass.Audiologist,
									Address = "Avenue 4 - Florianopolis, BRA",
									OpeningHours = "Mon-Fri\n09:30 - 17:00"
								 },
					new HostPerson {
									Id = 5,
									Name = "Mr. Jackson",
									HostClass = HostClass.ADBSupportAgent,
									Address = "Street 5 - Gary, USA",
									OpeningHours = "Mon-Fri\n09:30 - 17:00"
								 },
					new HostPerson {
									Id = 6,
									Name = "Mr. Dylan",
									HostClass = HostClass.ADBSupportAgent,
									Address = "Street 6 - Duluth, USA",
									OpeningHours = "Mon-Fri\n09:30 - 17:00"
								 }
		};
		#endregion
	}
}
