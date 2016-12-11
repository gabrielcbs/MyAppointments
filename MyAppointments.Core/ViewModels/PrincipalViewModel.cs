using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MyAppointments.Core.ViewModels;

namespace MyAppointments.Core
{
	public class PrincipalViewModel : MvxViewModel, IPrincipalViewModel
	{
		readonly Lazy<ListAppointmentsViewModel> _listAppointmentsViewModel;
		readonly Lazy<ThisWeekAppointmentsViewModel> _thisWeekAppointmentsViewModel;

		public ListAppointmentsViewModel ListAppointmentsViewModel => _listAppointmentsViewModel.Value;
		public ThisWeekAppointmentsViewModel ThisWeekAppointmentsViewModel => _thisWeekAppointmentsViewModel.Value;


		public PrincipalViewModel()
		{
			_listAppointmentsViewModel = new Lazy<ListAppointmentsViewModel>(Mvx.IocConstruct<ListAppointmentsViewModel>);
			_thisWeekAppointmentsViewModel = new Lazy<ThisWeekAppointmentsViewModel>(Mvx.IocConstruct<ThisWeekAppointmentsViewModel>);
		}
	}
}
