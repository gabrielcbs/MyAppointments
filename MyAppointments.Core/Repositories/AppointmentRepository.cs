using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAppointments.Core.Contracts.Repositories;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Repositories
{
	public class AppointmentRepository : BaseRepository, IAppointmentRepository
	{
		public async Task<Appointment> GetAppointmentDetails(int appointmentId)
		{
			return await Task.FromResult(Appointments.FirstOrDefault(x => x.Id == appointmentId));
		}

		public async Task<IEnumerable<Appointment>> SearchAppointment(DateTime dateAndTime)
		{
			return await Task.FromResult(Appointments.Where(x => x.DateAndTime.Date == dateAndTime.Date));
		}

		public async Task<IEnumerable<Appointment>> GetAppointments()
		{
			return await Task.FromResult(Appointments.OrderBy(x => x.DateAndTime));
		}

		/// <summary>
		/// Gets the appointments this week(next 7 days, including today and the 7th day).
		/// </summary>
		/// <returns>The appointments this week.</returns>
		public async Task<IEnumerable<Appointment>> GetAppointmentsThisWeek()
		{
			return await Task.FromResult(Appointments
										 .Where(x =>
												x.DateAndTime.Date >= DateTime.Now.Date
												  && x.DateAndTime.Date <= DateTime.Now.AddDays(7).Date)
										 .OrderBy(x => x.DateAndTime));
		}

		#region Mock Appointments
		static readonly List<Appointment> Appointments = new List<Appointment>
		{
					new Appointment {
										Id = 1,
										HostPerson = new HostPerson { Id = 1, Name = "Dr. Occhilupo" },
										DateAndTime = DateTime.Parse("10/25/2017"),
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
	}
}
