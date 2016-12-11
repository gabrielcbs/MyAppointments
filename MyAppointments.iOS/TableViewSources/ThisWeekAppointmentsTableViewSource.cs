using System;
using Foundation;
using MvvmCross.Binding.ExtensionMethods;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MyAppointments.iOS.TableViewSources
{
	//TODO: Substitute this class for ListAppointmentsTableViewSource if possible
	public class ThisWeekAppointmentsTableViewSource : MvxTableViewSource
	{
		public ThisWeekAppointmentsTableViewSource(UITableView tableView) : base(tableView)
		{
		}

		public ThisWeekAppointmentsTableViewSource(IntPtr handle) : base(handle)
		{
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return ItemsSource.Count();
		}

		protected override UITableViewCell GetOrCreateCellFor
			(UITableView tableView, NSIndexPath indexPath, object item)
		{
			var cell = (AppointmentCell)
				tableView.DequeueReusableCell(AppointmentCell.Identifier);
			return cell;
		}

		protected override object GetItemAt(NSIndexPath indexPath)
		{
			return ItemsSource?.ElementAt(indexPath.Row);
		}
	}
}
