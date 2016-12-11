using System.Collections.Generic;
using System.Threading.Tasks;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Contracts.Services
{
	public interface IHostPersonDataService
	{
		Task<IPerson> GetHostPersonDetails(int personId);

		Task<IEnumerable<IPerson>> SearchHostPerson(string name);
	}
}
