using System.Collections.Generic;
using System.Threading.Tasks;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Contracts.Repositories
{
	public interface IHostPersonRepository
	{
		Task<IPerson> GetHostPersonDetails(int personId);

		Task<IEnumerable<IPerson>> SearchHostPerson(string name);
	}
}
