using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MyAppointments.Core.Converters;
using MyAppointments.Core.Models;

namespace MyAppointments.iOS
{
	public partial class AppointmentCell : MvxTableViewCell
	{
		internal static readonly NSString Identifier =
			new NSString("AppointmentCell");

		public AppointmentCell(IntPtr handle) : base(handle)
		{
		}

		void CreateBindings()
		{
			var set = this.CreateBindingSet<AppointmentCell, Appointment>();

			set.Bind(HostLabel)
			   .To(vm => vm.HostPerson.Name);

			set.Bind(DateAndTimeLabel)
				.To(vm => vm.DateAndTime)
			    .WithConversion(new DateTimeToDayConverter());

			set.Apply();
		}

		public override void LayoutSubviews()
		{
			base.LayoutSubviews();
			CreateBindings();
		}
	}
}