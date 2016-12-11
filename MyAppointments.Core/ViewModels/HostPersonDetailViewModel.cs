using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Plugins.Messenger;
using MyAppointments.Core.Contracts.Services;
using MyAppointments.Core.Contracts.ViewModels;
using MyAppointments.Core.Models;

namespace MyAppointments.Core.ViewModels
{
	public class HostPersonDetailViewModel : BaseViewModel, IHostPersonDetailViewModel
	{
		readonly IHostPersonDataService _hostPersonDataService;
		HostPerson _selectedHostPerson;
		int _hostPersonId;

		#region Properties
		public MvxCommand CloseCommand
		{
			get { return new MvxCommand(() => Close(this)); }
		}

		public HostPerson SelectedHostPerson
		{
			get { return _selectedHostPerson; }
			set
			{
				_selectedHostPerson = value;
				RaisePropertyChanged(() => SelectedHostPerson);
			}
		}
		#endregion

		public HostPersonDetailViewModel(IMvxMessenger messenger,
			IHostPersonDataService hostPersonDataService
										 //ISavedAppointmentDataService savedAppointmentDataService,
										 //IDialogService dialogService,
										 //IUserDataService userDataService
										 ) : base(messenger)
		{
			_hostPersonDataService = hostPersonDataService;
			//_savedAppointmentDataService = savedAppointmentDataService;
			//_dialogService = dialogService;
			//_userDataService = userDataService;
		}

		public void Init(int hostPersonId)
		{
			_hostPersonId = hostPersonId;
		}

		public override async void Start()
		{
			base.Start();
			await ReloadDataAsync();
		}

		protected override async Task InitializeAsync()
		{
			SelectedHostPerson = (HostPerson)await _hostPersonDataService.GetHostPersonDetails(_hostPersonId);
		}

		#region SavedState

		public class SavedState
		{
			public int HostPersonId { get; set; }
		}

		public SavedState SaveState()
		{
			MvxTrace.Trace("SaveState called");
			return new SavedState { HostPersonId = _hostPersonId };
		}

		public void ReloadState(SavedState savedState)
		{
			MvxTrace.Trace("ReloadState called with {0}",
				savedState.HostPersonId);
			_hostPersonId = savedState.HostPersonId;
		}

		#endregion
	}
}
