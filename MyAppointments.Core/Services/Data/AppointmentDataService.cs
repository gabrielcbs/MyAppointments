using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyAppointments.Core.Contracts.Repositories;
using MyAppointments.Core.Contracts.Services;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.Services.Data
{
	/// <summary>
	/// Here we set some business rules
	/// </summary>
	public class AppointmentDataService : IAppointmentDataService
	{
		readonly IAppointmentRepository _appointmentRepository;

		public AppointmentDataService(IAppointmentRepository appointmentRepository)
		{
			_appointmentRepository = appointmentRepository;
		}

		public async Task<IEnumerable<Appointment>> GetAppointments()
		{
			var appointments = await _appointmentRepository.GetAppointments();

			return appointments;
		}

		public async Task<IEnumerable<Appointment>> GetAppointmentsThisWeek()
		{
			var appointments = await _appointmentRepository.GetAppointmentsThisWeek();

			return appointments;
		}

		public async Task<IEnumerable<Appointment>> SearchAppointment(DateTime dateAndTime)
		{
			var appointments = await _appointmentRepository.SearchAppointment(dateAndTime);

			//TODO: Eventual Business rule

			return appointments;
		}

		public async Task<Appointment> GetAppointmentDetails(int appointmentId)
		{
			return await _appointmentRepository.GetAppointmentDetails(appointmentId);
		}
	}
}
