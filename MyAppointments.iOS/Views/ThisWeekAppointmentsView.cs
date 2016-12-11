using System;
using MvvmCross.Binding.BindingContext;
using MyAppointments.Core.ViewModels;
using MyAppointments.iOS.TableViewSources;

namespace MyAppointments.iOS.Views
{
	public partial class ThisWeekAppointmentsView : BaseView
	{
		ThisWeekAppointmentsTableViewSource _thisWeekAppointmentsTableViewSource;

		public ThisWeekAppointmentsView(IntPtr handle) : base(handle)
		{
			Title = "This Week Appointments";
		}

		protected ThisWeekAppointmentsViewModel ThisWeekAppointmentsViewModel
		=> ViewModel as ThisWeekAppointmentsViewModel;

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		protected override void CreateBindings()
		{
			var set = this.CreateBindingSet<ThisWeekAppointmentsView, ThisWeekAppointmentsViewModel>();

			set.Bind(_thisWeekAppointmentsTableViewSource).To(vm => vm.Appointments);
			set.Bind(_thisWeekAppointmentsTableViewSource)
			   .For(source => source.SelectionChangedCommand)
			   .To(vm => vm.ShowAppointmentDetailsCommand);

			set.Apply();
		}

		public override void ViewDidLoad()
		{
			_thisWeekAppointmentsTableViewSource = new 
				ThisWeekAppointmentsTableViewSource(ThisWeekAppointmentsTableView);

			base.ViewDidLoad();

			ThisWeekAppointmentsTableView.Source = _thisWeekAppointmentsTableViewSource;
			ThisWeekAppointmentsTableView.ReloadData();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			ThisWeekAppointmentsViewModel.ReloadDataCommand.Execute();
			ThisWeekAppointmentsTableView.DeselectRow(ThisWeekAppointmentsTableView.IndexPathForSelectedRow, true);
		}
	}
}