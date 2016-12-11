using System;
using MvvmCross.Binding.BindingContext;
using MyAppointments.Core.ViewModels;

namespace MyAppointments.iOS
{
	public partial class AppointmentDetailView : BaseView
	{
		protected AppointmentDetailViewModel AppointmentDetailViewModel
			=> ViewModel as AppointmentDetailViewModel;

		public AppointmentDetailView(IntPtr handle) : base(handle)
		{
			Title = "Appointment Details";
		}

		protected override void CreateBindings()
		{
			base.CreateBindings();

			var set = this.CreateBindingSet<AppointmentDetailView, AppointmentDetailViewModel>();

			set.Bind(DateAndTimeTextField)
			   .To(vm => vm.SelectedAppointment.DateAndTime);

			set.Bind(HostTextField)
			   .To(vm => vm.SelectedAppointment.HostPerson.Name);

			set.Bind(NotesTextView)
			   .To(vm => vm.SelectedAppointment.Notes);

			set.Bind(HostDetailsButton)
			   .To(vm => vm.ShowHostPersonDetailsCommand);

			set.Apply();
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// CloseButton.Layer.BorderWidth = 1;
			// CloseButton.Layer.BorderColor = UIColor.Black;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}

		#endregion
	}
}
