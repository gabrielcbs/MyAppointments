using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Plugins.Messenger;
using MyAppointments.Core.Contracts.Services;
using MyAppointments.Core.Contracts.ViewModels;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.ViewModels
{
	public class AppointmentDetailViewModel : BaseViewModel, IAppointmentDetailViewModel
	{
		readonly IAppointmentDataService _appointmentDataService;
		Appointment _selectedAppointment;
		int _appointmentId;

		#region Properties
		public MvxCommand CloseCommand
		{
			get { return new MvxCommand(() => Close(this)); }
		}

		public Appointment SelectedAppointment
		{
			get { return _selectedAppointment; }
			set
			{
				_selectedAppointment = value;
				RaisePropertyChanged(() => SelectedAppointment);
			}
		}

		public MvxCommand<HostPerson> ShowHostPersonDetailsCommand
		{
			get
			{
				return new MvxCommand<HostPerson>(selectedHostPerson =>
								{
									ShowViewModel<HostPersonDetailViewModel>
										(new { hostPersonId = SelectedAppointment.HostPerson.Id });
								});

			}
		}
		#endregion

		public AppointmentDetailViewModel(IMvxMessenger messenger,
			IAppointmentDataService appointmentDataService
										 //ISavedAppointmentDataService savedAppointmentDataService,
										 //IDialogService dialogService,
										 //IUserDataService userDataService
										 ) : base(messenger)
		{
			_appointmentDataService = appointmentDataService;
			//_savedAppointmentDataService = savedAppointmentDataService;
			//_dialogService = dialogService;
			//_userDataService = userDataService;
		}

		public void Init(int appointmentId)
		{
			_appointmentId = appointmentId;
		}

		public override async void Start()
		{
			base.Start();
			await ReloadDataAsync();
		}

		protected override async Task InitializeAsync()
		{
			SelectedAppointment = await _appointmentDataService.GetAppointmentDetails(_appointmentId);
		}

		#region SavedState

		public class SavedState
		{
			public int AppointmentId { get; set; }
		}

		public SavedState SaveState()
		{
			MvxTrace.Trace("SaveState called");
			return new SavedState { AppointmentId = _appointmentId };
		}

		public void ReloadState(SavedState savedState)
		{
			MvxTrace.Trace("ReloadState called with {0}",
				savedState.AppointmentId);
			_appointmentId = savedState.AppointmentId;
		}

		#endregion
	}
}
