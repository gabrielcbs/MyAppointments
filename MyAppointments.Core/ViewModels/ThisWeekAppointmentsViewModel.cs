using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using MyAppointments.Core.Contracts.Services;
using MyAppointments.Core.Models;
using MyAppointments.Core.Extensions;
using MyAppointments.Core.Contracts.ViewModels;

namespace MyAppointments.Core.ViewModels
{
	public class ThisWeekAppointmentsViewModel : BaseViewModel, IListAppointmentsViewModel
	{
		readonly IAppointmentDataService _appointmentDataService;
		ObservableCollection<Appointment> _appointments;

		public ObservableCollection<Appointment> Appointments
		{
			get { return _appointments; }
			set
			{
				_appointments = value;
				RaisePropertyChanged(() => Appointments);
			}
		}

		public MvxCommand<Appointment> ShowAppointmentDetailsCommand
		{
			get
			{
				return new MvxCommand<Appointment>(selectedAppointment =>
								{
									ShowViewModel<AppointmentDetailViewModel>
									(new { appointmentId = selectedAppointment.Id });

								});

			}
		}


		public MvxCommand ReloadDataCommand
		{
			get
			{
				return new MvxCommand(async () =>
				{
					Appointments = (await _appointmentDataService.GetAppointmentsThisWeek()).ToObservableCollection();
				});
			}
		}

		public ThisWeekAppointmentsViewModel(IMvxMessenger messenger, IAppointmentDataService appointmentDataService)
			: base(messenger)
		{
			_appointmentDataService = appointmentDataService;

			InitializeMessenger();
		}

		void InitializeMessenger()
		{
			//TODO: Remove if not required
			// Messenger.Subscribe<CurrencyChangedMessage>
			//	(async message => await ReloadDataAsync());
		}

		public override async void Start()
		{
			base.Start();

			await ReloadDataAsync();
		}

		protected override async Task InitializeAsync()
		{
			Appointments = (await _appointmentDataService.GetAppointmentsThisWeek()).ToObservableCollection();
		}


	}
}
