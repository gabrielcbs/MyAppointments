using System.Collections.Generic;
using System.Threading.Tasks;
using MyAppointments.Core.Contracts.Repositories;
using MyAppointments.Core.Contracts.Services;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Services.Data
{
	public class HostPersonDataService : IHostPersonDataService
	{
		readonly IHostPersonRepository _hostPersonRepository;

		public HostPersonDataService(IHostPersonRepository hostPersonRepository)
		{
			_hostPersonRepository = hostPersonRepository;
		}

		public async Task<IEnumerable<IPerson>> SearchHostPerson(string name)
		{
			var people = await _hostPersonRepository.SearchHostPerson(name);

			//TODO: Eventual Business rule

			return people;
		}

		public async Task<IPerson> GetHostPersonDetails(int personId)
		{
			return await _hostPersonRepository.GetHostPersonDetails(personId);
		}
	}
}
