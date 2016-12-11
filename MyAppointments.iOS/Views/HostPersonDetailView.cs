using System;
using MvvmCross.Binding.BindingContext;
using MyAppointments.Core.ViewModels;

namespace MyAppointments.iOS
{
	public partial class HostPersonDetailView : BaseView
    {
		protected HostPersonDetailViewModel HostPersonDetailViewModel
			=> ViewModel as HostPersonDetailViewModel;

		public HostPersonDetailView(IntPtr handle) : base(handle)
		{
			Title = "Host Person Details";
		}

		protected override void CreateBindings()
		{
			base.CreateBindings();

			var set = this.CreateBindingSet<HostPersonDetailView, HostPersonDetailViewModel>();

			set.Bind(NameTextField)
			   .To(vm => vm.SelectedHostPerson.Name);

			set.Bind(OpeningHoursTextView)
			   .To(vm => vm.SelectedHostPerson.OpeningHours);

			set.Bind(AddressTextView)
			   .To(vm => vm.SelectedHostPerson.Address);

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