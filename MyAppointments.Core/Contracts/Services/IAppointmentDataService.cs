using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Contracts.Services
{
	public interface IAppointmentDataService
	{
		Task<IEnumerable<Appointment>> SearchAppointment(DateTime dateAndTime);

		Task<IEnumerable<Appointment>> GetAppointments();

		Task<IEnumerable<Appointment>> GetAppointmentsThisWeek();

		Task<Appointment> GetAppointmentDetails(int appointmentId);
	}
}
