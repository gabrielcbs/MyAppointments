using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAppointments.Core.Contracts.Repositories;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Repositories
{
	public class HostPersonRepository : BaseRepository, IHostPersonRepository
	{
		IEnumerable<IPerson> people;

		public HostPersonRepository()
		{
			people = MockRepository.People;
		}

		public async Task<IPerson> GetHostPersonDetails(int appointmentId)
		{
			return await Task.FromResult(people.FirstOrDefault(x => x.Id == appointmentId));
		}

		public async Task<IEnumerable<IPerson>> SearchHostPerson(string name)
		{
			return await Task.FromResult(people.Where(x => x.Name == name));
		}
	}
}
