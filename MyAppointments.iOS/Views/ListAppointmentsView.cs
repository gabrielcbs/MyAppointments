using System;
using MvvmCross.Binding.BindingContext;
using MyAppointments.Core.ViewModels;
using MyAppointments.iOS.TableViewSources;

namespace MyAppointments.iOS.Views
{
	public partial class ListAppointmentsView : BaseView
	{
		ListAppointmentsTableViewSource _listAppointmentsTableViewSource;

		public ListAppointmentsView(IntPtr handle) : base(handle)
		{
			Title = "All Appointments";
		}

		protected ListAppointmentsViewModel ListAppointmentsViewModel
		=> ViewModel as ListAppointmentsViewModel;

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		protected override void CreateBindings()
		{
			var set = this.CreateBindingSet<ListAppointmentsView, ListAppointmentsViewModel>();

			set.Bind(_listAppointmentsTableViewSource).To(vm => vm.Appointments);
			set.Bind(_listAppointmentsTableViewSource)
			   .For(source => source.SelectionChangedCommand)
			   .To(vm => vm.ShowAppointmentDetailsCommand);

			set.Apply();
		}

		public override void ViewDidLoad()
		{
			_listAppointmentsTableViewSource = new ListAppointmentsTableViewSource(ListAppointmentsTableView);

			base.ViewDidLoad();

			ListAppointmentsTableView.Source = _listAppointmentsTableViewSource;
			ListAppointmentsTableView.ReloadData();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

            ListAppointmentsViewModel.ReloadDataCommand.Execute();
            ListAppointmentsTableView.DeselectRow(ListAppointmentsTableView.IndexPathForSelectedRow, true);
   		}
	}
}