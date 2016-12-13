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
		IEnumerable<Appointment> appointments;

		public AppointmentRepository()
		{
			appointments = MockRepository.Appointments;
		}

		public async Task<Appointment> GetAppointmentDetails(int appointmentId)
		{
			return await Task.FromResult(appointments.FirstOrDefault(x => x.Id == appointmentId));
		}

		public async Task<IEnumerable<Appointment>> SearchAppointment(DateTime dateAndTime)
		{
			return await Task.FromResult(appointments.Where(x => x.DateAndTime.Date == dateAndTime.Date));
		}

		public async Task<IEnumerable<Appointment>> GetAppointments()
		{
			return await Task.FromResult(appointments.OrderBy(x => x.DateAndTime));
		}

		/// <summary>
		/// Gets the appointments this week(next 7 days, including today and the 7th day).
		/// </summary>
		/// <returns>The appointments this week.</returns>
		public async Task<IEnumerable<Appointment>> GetAppointmentsThisWeek()
		{
			return await Task.FromResult(appointments
										 .Where(x =>
												x.DateAndTime.Date >= DateTime.Now.Date
												  && x.DateAndTime.Date <= DateTime.Now.AddDays(7).Date)
										 .OrderBy(x => x.DateAndTime));
		}


	}
}
