// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyAppointments.iOS.Views
{
    [Register ("ListAppointmentsView")]
    partial class ListAppointmentsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ListAppointmentsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ListAppointmentsTableView != null) {
                ListAppointmentsTableView.Dispose ();
                ListAppointmentsTableView = null;
            }
        }
    }
}